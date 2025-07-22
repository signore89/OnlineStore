using System.Text.Json.Serialization;

namespace OnlineStoreDouble.Models
{
    public class ProductCategory
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public required string Name { get; set; }
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        public override string ToString()
        {
            return $"Id: {Id},Имя: {Name}, Описание: {Description}";
        }
    }
}
