using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CurseForge.APIClient.Models.Games
{
    public class GameVersionsByType2
    {
        [JsonPropertyName("type")]
        public int Type { get; set; }
        [JsonPropertyName("versions")]
        public List<GameVersion> Versions { get; set; } = new List<GameVersion>();
    }
}
