using CurseForge.APIClient.Models.Files;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CurseForge.APIClient.Models.Fingerprints
{
    public class FingerprintFuzzyMatch
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("file")]
        public File File { get; set; }
        [JsonPropertyName("latestFiles")]
        public List<File> LatestFiles { get; set; } = new List<File>();
        [JsonPropertyName("fingerprints")]
        public List<long> Fingerprints { get; set; } = new List<long>();
    }
}
