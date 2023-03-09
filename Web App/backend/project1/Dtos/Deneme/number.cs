using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace project1.Dtos.Deneme
{
    public class number

    { 

     public  string operation { get; set; }

        public double result { get; set; }


        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string id { get; set; }
    }
}
