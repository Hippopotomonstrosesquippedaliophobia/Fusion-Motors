using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;
using MongoDB.Driver.Core.Operations;

namespace Database_Application_Chris
{
    class Firestore
    {

        public FirestoreDb db; // global reference to firestore database

        public Firestore() 
        {
            //Connect to firebase
            string path = AppDomain.CurrentDomain.BaseDirectory + @"Exclude from GIT/fusion-motors-firebase.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            db = FirestoreDb.Create("fusion-motors");  
        }

        //Not being used
        void AddAutoID()
        {
            CollectionReference cll = db.Collection("Login");

            Dictionary<string, object> dict = new Dictionary<string, object>()
            {
                {"firstname","Administrator" },
                {"lastname","Account" },
                {"username","admin" },
                {"password","password" },
                {"priviledge", 0 },
                {"datecreated", "11/06/2024" } 
            };

            cll.AddAsync(dict);
            //MessageBox.Show("Added");
        }
        void AddCustomID()
        {
            DocumentReference doc = db.Collection("Login").Document("admin");

            Dictionary<string, object> dict = new Dictionary<string, object>()
            {
                {"firstname","Administrator" },
                {"lastname","Account" },
                {"username","admin" },
                {"password","password" },
                {"priviledge", 0 },
                {"datecreated", "11/06/2024" }
            };

            //ArrayList array = new ArrayList();
            //array.Add("test1");
            //array.Add(true);
            //array.Add(123);
            //dict.Add("Array list", array);

            //Dictionary<string, object> dict2 = new Dictionary<string, object>()
            //{
            //    {"firstname","Administrator" },
            //    {"username","admin" }
            //};

            //dict.Add("List added", dict2);


            doc.SetAsync(dict); 
        }
    }
}
