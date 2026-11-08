using System.Text.Json.Serialization;

namespace IDHLDeveloperTest.Models
{
    public class Character
    {
        [JsonPropertyName("_id")]
        public int Id { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonPropertyName("films")]
        public string[] Films { get; set; } = [];

        [JsonPropertyName("shortFilms")]
        public string[] ShortFilms { get; set; } = [];

        [JsonPropertyName("tvShows")]
        public string[] TvShows { get; set; } = [];

        [JsonPropertyName("videoGames")]
        public string[] VideoGames { get; set; } = [];

        [JsonPropertyName("parkAttractions")]
        public string[] ParkAttractions { get; set; }

        [JsonPropertyName("allies")]
        public string[] Allies { get; set; }

        [JsonPropertyName("enemies")]
        public string[] Enemies { get; set; }
    }
}
