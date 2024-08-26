using CurseForge.APIClient.Models.Enums;
using System.Text.Json.Serialization;

namespace CurseForge.APIClient.Models.Files
{
    public class FileHash
    {
        [JsonPropertyName("value")]
        public string Value { get; set; }
        [JsonPropertyName("algo")]
        public HashAlgo Algo { get; set; }
    }
}
