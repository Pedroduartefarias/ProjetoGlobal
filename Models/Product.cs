﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ProjetoGlobal.Models
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)] 
        public string Id { get; set; }

        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
