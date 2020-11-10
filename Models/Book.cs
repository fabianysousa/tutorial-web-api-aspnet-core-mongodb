using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace BooksApi.Models
{
    public class Book
    {
        // [BsonID] : Informa a chave primária do documento
        // [BsonRepresentation(BsonType.ObjectId)] : Permite a passagem de parâmetro como tipo string em vez de uma estrutura ObjectID. Faz a conversão de string para ObjectID 
        // [BsonElement] : Propriedade da coleção MongoDB

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        [JsonProperty("Name")]
        public string BookName { get; set; }

        public decimal Price { get; set; }

        public string Category { get; set; }

        public string Author { get; set; }
    }

}


