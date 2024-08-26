using CurseForge.APIClient.Models.Mods;
using System.Text.Json.Serialization;

namespace CurseForge.APIClient.Models.Files
{
    public class FileIndex
    {
        [JsonPropertyName("gameVersion")]
        public string GameVersion { get; set; }
        [JsonPropertyName("fileId")]
        public int FileId { get; set; }
        [JsonPropertyName("filename")]
        public string Filename { get; set; }
        [JsonPropertyName("releaseType")]
        public FileReleaseType ReleaseType { get; set; }
        [JsonPropertyName("gameVersionTypeId")]
        public int? GameVersionTypeId { get; set; }
        [JsonPropertyName("modLoader")]
        public ModLoaderType? ModLoader { get; set; }
    }
}
