using CurseForge.APIClient.Models.Enums;
using System;
using System.Text.Json.Serialization;

namespace CurseForge.APIClient.Models.Games
{
    public class Game
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("slug")]
        public string Slug { get; set; }
        [JsonPropertyName("dateModified")]
        public DateTimeOffset DateModified { get; set; }
        [JsonPropertyName("assets")]
        public GameAssets Assets { get; set; }
        [JsonPropertyName("status")]
        public CoreStatus Status { get; set; }
        [JsonPropertyName("apiStatus")]
        public CoreApiStatus ApiStatus { get; set; }
    }
}
