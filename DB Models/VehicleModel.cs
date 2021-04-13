using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Database_Application_Chris
{
    public class VehicleModel
    {
        [BsonId] // _id
        public Guid Id { get; set; }

        public string EngineNum { get; set; }
        public string ChassisNum { get; set; }
        public string Colour { get; set; }
        public string[] InterestedCustomers { get; set; } 
    }
}
