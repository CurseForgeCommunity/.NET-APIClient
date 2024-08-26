using System.Text.Json.Serialization;

namespace CurseForge.APIClient.Models.Games
{
    public class GameAssets
    {
        [JsonPropertyName("iconUrl")]
        public string IconUrl { get; set;}
        [JsonPropertyName("tileUrl")]
        public string TileUrl {  get; set;}
        [JsonPropertyName("coverUrl")]
        public string CoverUrl {  get; set; }
    }
}
