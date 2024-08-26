using System.Text.Json.Serialization;

namespace CurseForge.APIClient.Models.Mods
{
    public class ModAuthor
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
