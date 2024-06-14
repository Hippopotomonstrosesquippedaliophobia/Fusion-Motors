using Google.Cloud.Firestore;
using System.Collections.Generic;

namespace Database_Application_Chris
{
    [FirestoreData]
    public class VehicleFrame
    { 
        [FirestoreProperty]
        public string EngineNumber { get; set; }
        [FirestoreProperty]
        public string ChassisNumber { get; set; }
        [FirestoreProperty]
        public string Owner { get; set; }
        [FirestoreProperty]
        public string Make { get; set; }
        [FirestoreProperty]
        public string Model { get; set; }
        [FirestoreProperty]
        public int Year { get; set; }
        [FirestoreProperty]
        public int Valuation { get; set; }
        [FirestoreProperty]
        public int AskingPrice { get; set; }
        [FirestoreProperty]
        public string Colour { get; set; }
        [FirestoreProperty]
        public string Notes { get; set; } 
        [FirestoreProperty]
        public List<string> CustomerInterest { get; set; } 


        //gotta figure this out
        //[FirestoreProperty]
        //public string image { get; set; }

    }
}