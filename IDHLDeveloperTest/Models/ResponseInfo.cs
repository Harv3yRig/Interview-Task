using System.Text.Json.Serialization;

namespace IDHLDeveloperTest.Models
{
    public class ResponseInfo
    {

        [JsonPropertyName("totalPages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }
    }
}
