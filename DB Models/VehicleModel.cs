using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace Database_Application_Chris
{
    public class VehicleModel
    {
        [BsonId] // _id
        public Guid Id { get; set; }

        public string Owner { get; set; }
        public string EngineNum { get; set; }
        public string ChassisNum { get; set; }
        public string Colour { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Valuation { get; set; }
        public double AskingPrice { get; set; }
        public List<string> InterestedCustomers { get; set; } 
    }
}
