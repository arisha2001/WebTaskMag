using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace ClientServer.Shared
{
    public class User
    {
        [BsonId] 
        [BsonRepresentation(BsonType.ObjectId)] 
        public string Id { get; set; }

        [BsonElement]
        public string Name { get; set; } = null!;

        [BsonElement]
        public string Email { get; set; } = null!;
    
        [BsonElement]
        public string Password { get; set; } = null!;
    }
}
