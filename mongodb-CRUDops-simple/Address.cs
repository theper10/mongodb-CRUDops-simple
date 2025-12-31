using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mongodb_CRUDops_simple
{
    internal class Address
    {
        [BsonElement("street")]
        public string Street { get; set; } = "";

        [BsonElement("city")]
        public string City { get; set; } = "";

        [BsonElement("postal_code")]
        public string? PostalCode { get; set; } = "";
    }
}
