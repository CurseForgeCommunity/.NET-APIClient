using System.Text.Json.Serialization;

namespace CurseForge.APIClient.Models.Games
{
    public class GameVersion
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("slug")]
        public string Slug { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
