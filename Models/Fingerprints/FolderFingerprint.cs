using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CurseForge.APIClient.Models.Fingerprints
{
    public class FolderFingerprint
    {
        [JsonPropertyName("foldername")]
        public string Foldername { get; set; }
        [JsonPropertyName("fingerprints")]
        public List<long> Fingerprints { get; set; } = new List<long>();
    }
}
