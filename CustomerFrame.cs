using Google.Cloud.Firestore;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
using System;

namespace Database_Application_Chris
{
    [FirestoreData]
    public class CustomerFrame
    {
        [FirestoreProperty]
        public Guid Id { get; set; }

        [FirestoreProperty]
        public string FirstName { get; set; }
        [FirestoreProperty]
        public string LastName { get; set; }
        [FirestoreProperty]
        public string Address { get; set; }
        [FirestoreProperty]
        public string ContactNum1 { get; set; }
        [FirestoreProperty]
        public string ContactNum2 { get; set; }
        [FirestoreProperty]
        public string[] Emails { get; set; }
        [FirestoreProperty]
        public List<string> InterestedVehicles { get; set; }
        [FirestoreProperty]
        public bool InProgressFlag { get; set; }
        [FirestoreProperty]
        public bool CallBackFlag { get; set; }
        [FirestoreProperty]
        public string Notes { get; set; }
    }
}