using CurseForge.APIClient.Models.Files;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CurseForge.APIClient.Models.Fingerprints
{
    public class FingerprintMatch
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("file")]
        public File File { get; set; }
        [JsonPropertyName("latestFiles")]
        public List<File> LatestFiles { get; set; } = new List<File>();
    }
}
