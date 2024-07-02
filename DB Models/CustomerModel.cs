using Google.Cloud.Firestore;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
using System;

namespace Database_Application_Chris
{ 
    public class CustomerModel
    { 
        public Guid Id { get; set; }
         
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public AddressModel PrimaryAddress { get; set; } 
        public ContactModel ContactNums { get; set; } 
        public EmailModel Emails { get; set; } 
        public List<string> InterestedVehicles { get; set; } 
        public bool InProgressFlag { get; set; } 
        public bool CallBackFlag { get; set; } 
        public string Notes { get; set; }
    }
}