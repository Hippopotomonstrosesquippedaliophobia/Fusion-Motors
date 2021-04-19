using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Application_Chris
{
    public class MongoCRUD
    {
        private IMongoDatabase db { get; } 

        public MongoCRUD (string database)
        {
            // Asynchronously initialize this instance.
            var client = new MongoClient("mongodb://localhost:27017");

            try
            {
                db = client.GetDatabase(database);
            }
            catch (Exception err)
            {

            }      
        } 

        public void GetConnection()
        {
            try
            {
                db.RunCommand((Command<BsonDocument>)"{ping:1}");

                main.Instance.Invoke((MethodInvoker)delegate {
                    // Running on the UI thread
                    Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                    string database = config.AppSettings.Settings["database"].Value.ToString();

                    main.Instance.mongoStatusLblTxt = "Mongo: Connected";   
                    main.Instance.mongoDBLblTxt = database;   
                });
            }
            catch (Exception err)
            {
                main.Instance.Invoke((MethodInvoker)delegate {
                    // Running on the UI thread
                    main.Instance.mongoStatusLblTxt = "Mongo: Not Connected";
                    main.Instance.mongoDBLblTxt = "No Database"; 

                    if (!main.Instance.alertDisconnect)
                    {
                        main.Instance.alertDisconnect = true;
                        MessageBox.Show("Disconnected from MongoDB\n", "Mongo Connection Issue", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    }
                });
            }
        }

        public void InsertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);

            try
            {
                collection.InsertOne(record);
                MessageBox.Show("Successfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        public List<string> GetCollections()
        {
            List<string> collections = new List<string>();

            try
            {
                foreach (BsonDocument collection in db.ListCollectionsAsync().Result.ToListAsync<BsonDocument>().Result)
                {
                    collections.Add(collection["name"].AsString);
                }

                return collections;
            }
            catch (Exception err)
            {
                return null;
            }
        }

        public List<T> LoadRecords<T>(string table)
        {
            var collection = db.GetCollection<T>(table);

            try
            {
                return collection.Find(new BsonDocument()).ToList();
            } catch (Exception err)
            {
                return null;
            }
        }
        
        public List<CustomerModel> LoadCustomersToCallback<CustomerModel>(string table)
        {
            var collection = db.GetCollection<CustomerModel>(table);

            // Checks for engine no despite capitalization
            var filter = Builders<CustomerModel>.Filter.Eq("CallBackFlag", true);

            try
            {
                return collection.Find(filter).ToList();
            }
            catch (Exception err)
            {
                return null;
            }
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
            try
            {
                return collection.Find(filter).ToList();
            }
            catch (Exception err)
            {
                return null;
            }
        }

        public List<T> LoadCustomerById<T>(string table, Guid id)
        {
            var collection = db.GetCollection<T>(table);

            // Checks for engine no despite capitalization
            var filter = Builders<T>.Filter.Eq("Id", id);
             
            try
            {
                return collection.Find(filter).ToList();
            }
            catch (Exception err)
            {
                return null;
            }
        }

        public List<T> LoadVehicleByEngine<T>(string table, string engineNo)
        {
            var collection = db.GetCollection<T>(table);

            // Checks for engine no despite capitalization
            var filter = Builders<T>.Filter.Regex("EngineNum", new BsonRegularExpression("/^" + engineNo + "$/i"));

            try
            {
                //List<CustomerModel> listcust = UpdateVehicleInterestedList<CustomerModel>(table, engineNo); 
                return collection.Find(filter).ToList();
            }
            catch (Exception err)
            {
                return null;
            }
        }

        // RECENT ADD - NOT SURE **************************************************************************************
        public void UpdateVehicleInterestedList<T>(string table, string engineNumber, Guid id)
        {
            var collection = db.GetCollection<VehicleModel>(table);

            var filter = Builders<VehicleModel>.Filter.Where(x => x.EngineNum == engineNumber);
            var update = Builders<VehicleModel>.Update.Push("InterestedCustomers", Convert.ToString(id));

            collection.FindOneAndUpdate<T>(filter, update);
        }

        public void VehiclesListInterest<T>(string table, Guid id)
        {
            var collection = db.GetCollection<VehicleModel>("Vehicles");

            var collection2 = db.GetCollection<CustomerModel>("Customers");

            try
            {
                List<CustomerModel> customers = collection2.Find(new BsonDocument()).ToList();

                int index = 0;

                foreach (var cus in customers)
                {
                    int index2 = 0;

                    foreach (var item in customers[index2].InterestedVehicles)
                    {
                        var filter = Builders<VehicleModel>.Filter.And(
                            Builders<VehicleModel>.Filter.Where(x => x.EngineNum == customers[index2].InterestedVehicles[index2]));
                            //&&
                            //Builders<VehicleModel>.Filter.AnyNe<VehicleModel>(x => x.EngineNum, engineNumber); 
                            
                        index2++;
                    }
                    index++;
                }
            }
            catch (Exception err)
            { 
            }
            //var filter = Builders<VehicleModel>.Filter.Where(x => x.EngineNum == engineNumber);
            //var update = Builders<VehicleModel>.Update.Push("InterestedCustomers", Convert.ToString(id));

            //collection.FindOneAndUpdate<T>(filter, update);
        }
        //RECENT ADD - NOT SURE ***************************************************************************************

        public void UpsertRecord<T>(string table, Guid id, T record)
        {
            var collection = db.GetCollection<T>(table);

            try
            {
                var result = collection.ReplaceOne(
                                                    new BsonDocument("_id", id),
                                                    record,
                                                    new ReplaceOptions { IsUpsert = true }
                                                   );

                MessageBox.Show("Successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); 
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Upsert Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); 
            }
        } 

        public void DeleteRecord<T>(string table, Guid id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);

            try
            {
                collection.DeleteOne(filter);

                MessageBox.Show("Successfully deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }
    }
}
