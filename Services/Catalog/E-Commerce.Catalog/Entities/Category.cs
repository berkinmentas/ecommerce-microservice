using MongoDB.Bson.Serialization.Attributes;

namespace E_Commerce.Catalog.Entities
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string CategoryID { get; set; }

        public string CategoryName { get; set; }

    }
}
