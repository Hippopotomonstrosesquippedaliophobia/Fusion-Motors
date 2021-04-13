using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace Database_Application_Chris
{
    public class MongoCRUD
    {
        private IMongoDatabase db; 

        public MongoCRUD (string database)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            db = client.GetDatabase(database);
        }

        public async System.Threading.Tasks.Task GetConnectionAsync()
        {
            await db.RunCommandAsync((Command<BsonDocument>)"{ping:1}");
        }

        public void InsertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }

        public List<T> LoadRecords<T>(string table)
        {
            var collection = db.GetCollection<T>(table);

            return collection.Find(new BsonDocument()).ToList();
        }

        public List<T> LoadCustomerByName<T>(string table, string firstName, string lastName)
        {
            var collection = db.GetCollection<T>(table);

            //Starts with assumption only first name is provided
            var filter = Builders<T>.Filter.Regex("FirstName", new BsonRegularExpression("/^" + firstName + "$/i"));

            // If last name provided, then uses this variant of filter
            if (!firstName.Equals("") && !lastName.Equals(""))
            {
                filter = Builders<T>.Filter.And(
                                                Builders<T>.Filter.Regex("FirstName", new BsonRegularExpression("/^" + firstName + "$/i")),
                                                Builders<T>.Filter.Regex("LastName", new BsonRegularExpression("/^" + lastName + "$/i"))
                                            );

            } 

            return collection.Find(filter).ToList();
        }
        public List<T> LoadVehicleByEngine<T>(string table, string engineNo)
        {
            var collection = db.GetCollection<T>(table);

            // Checks for engine no despite capitalization
            var filter = Builders<T>.Filter.Regex("EngineNum", new BsonRegularExpression("/^" + engineNo + "$/i"));

            return collection.Find(filter).ToList();
        }


        public void UpsertRecord<T>(string table, Guid id, T record)
        {
            var collection = db.GetCollection<T>(table);

            var result = collection.ReplaceOne(
                                                new BsonDocument("_id", id),
                                                record,
                                                new ReplaceOptions { IsUpsert = true }
                                               );
        } 

        public void DeleteRecord<T>(string table, Guid id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);
            collection.DeleteOne(filter);
        }
    }
}
