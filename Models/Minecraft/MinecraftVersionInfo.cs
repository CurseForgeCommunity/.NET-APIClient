using CurseForge.APIClient.Models.Enums;
using System;
using System.Text.Json.Serialization;

namespace CurseForge.APIClient.Models.Minecraft
{
    public class MinecraftVersionInfo
    {
        [JsonPropertyName("id")]
        public uint Id { get; set; }
        [JsonPropertyName("gameVersionId")]
        public uint GameVersionId { get; set; }
        [JsonPropertyName("versionString")]
        public string VersionString { get; set; }
        [JsonPropertyName("jarDownloadUrl")]
        public string JarDownloadUrl { get; set; }
        [JsonPropertyName("jsonDownloadUrl")]
        public string JsonDownloadUrl { get; set; }
        [JsonPropertyName("approved")]
        public bool Approved { get; set; }
        [JsonPropertyName("dateModified")]
        public DateTimeOffset DateModified { get; set; }
        [JsonPropertyName("gameVersionTypeId")]
        public uint GameVersionTypeId { get; set; }
        [JsonPropertyName("gameVersionStatus")]
        public CoreGameVersionStatus GameVersionStatus { get; set; }
        [JsonPropertyName("gameVersionTypeStatus")]
        public CoreGameVersionTypeStatus GameVersionTypeStatus { get; set; }
    }
}
