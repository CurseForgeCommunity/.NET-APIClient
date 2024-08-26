using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CurseForge.APIClient.Models.Games
{
    public class GameVersionsByType
    {
        [JsonPropertyName("type")]
        public int Type { get; set; }
        [JsonPropertyName("versions")]
        public List<string> Versions { get; set; } = new List<string>();
    }
}
