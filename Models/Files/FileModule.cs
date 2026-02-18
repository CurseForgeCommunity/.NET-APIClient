using System.Text.Json.Serialization;

namespace CurseForge.APIClient.Models.Files
{
    public class FileModule : UnmappedCatcher
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("fingerprint")]
        public long Fingerprint { get; set; }
    }
}
