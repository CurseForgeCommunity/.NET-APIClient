using CurseForge.APIClient.Models.Enums;
using System;
using System.Text.Json.Serialization;

namespace CurseForge.APIClient.Models.Minecraft
{
    public class MinecraftModloaderInfoListItem
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("gameVersion")]
        public string GameVersion { get; set; }
        [JsonPropertyName("latest")]
        public bool Latest { get; set; }
        [JsonPropertyName("recommended")]
        public bool Recommended { get; set; }
        [JsonPropertyName("dateModified")]
        public DateTimeOffset DateModified { get; set; }
        [JsonPropertyName("type")]
        public CoreModloaderType Type { get; set; }
    }
}
