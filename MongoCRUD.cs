using MongoDB.Bson;
using MongoDB.Driver;
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

        public string GetConnection()
        {
            var collection = db.GetCollection<BsonDocument>("Customers");

            return collection.Find(new BsonDocument()).Limit(1).ToString();
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
    }
}
