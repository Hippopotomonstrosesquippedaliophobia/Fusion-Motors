using Google.Cloud.Firestore;

namespace Database_Application_Chris
{
    [FirestoreData]
    public class LoginDetails
    { 
        [FirestoreProperty]
        public string datecreated { get; set; }
        [FirestoreProperty]
        public string firstname { get; set; }
        [FirestoreProperty]
        public string lastname { get; set; }
        [FirestoreProperty]
        public string password { get; set; }
        [FirestoreProperty]
        public int priviledge { get; set; }
        [FirestoreProperty]
        public string username { get; set; }

    }
}