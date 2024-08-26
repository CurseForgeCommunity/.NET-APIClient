using System.Text.Json.Serialization;

namespace CurseForge.APIClient.Models.Mods
{
    public class ModAsset
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("modId")]
        public int ModId { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
