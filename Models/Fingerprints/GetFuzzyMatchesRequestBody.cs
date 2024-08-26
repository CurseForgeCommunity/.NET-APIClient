using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CurseForge.APIClient.Models.Fingerprints
{
    public class GetFuzzyMatchesRequestBody
    {
        [JsonPropertyName("gameId")]
        public int GameId { get; set; }
        [JsonPropertyName("fingerprints")]
        public List<FolderFingerprint> Fingerprints { get; set; } = new List<FolderFingerprint>();
    }
}
