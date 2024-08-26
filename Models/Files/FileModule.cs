using System.Text.Json.Serialization;

namespace CurseForge.APIClient.Models.Files
{
    public class FileModule
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("fingerprint")]
        public long Fingerprint { get; set; }
    }
}
