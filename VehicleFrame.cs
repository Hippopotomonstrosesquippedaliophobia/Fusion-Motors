using Google.Cloud.Firestore;

namespace Database_Application_Chris
{
    [FirestoreData]
    public class VehicleFrame
    { 
        [FirestoreProperty]
        public string enginenumber { get; set; }
        [FirestoreProperty]
        public string chassisnumber { get; set; }
        [FirestoreProperty]
        public string owner { get; set; }
        [FirestoreProperty]
        public string make { get; set; }
        [FirestoreProperty]
        public int model { get; set; }
        [FirestoreProperty]
        public string year { get; set; }
        [FirestoreProperty]
        public string valuation { get; set; }
        [FirestoreProperty]
        public string askingprice { get; set; }
        [FirestoreProperty]
        public string colour { get; set; }
        [FirestoreProperty]
        public string comments { get; set; }
        [FirestoreProperty]
        public string customerInterest { get; set; }


        //gotta figure this out
        //[FirestoreProperty]
        //public string image { get; set; }

    }
}