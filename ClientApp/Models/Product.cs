using System.Text.Json.Serialization;

namespace OnlineStoreDouble.Models
{
    public class Product
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public required string Name { get; set; }
        [JsonPropertyName("description")]
        public required string Description { get; set; }
        [JsonPropertyName("price")]
        public required decimal Price { get; set; }
    }
}
