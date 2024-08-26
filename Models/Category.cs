using System;
using System.Text.Json.Serialization;

namespace CurseForge.APIClient.Models
{
    public class Category
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("gameId")]
        public int GameId { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("slug")]
        public string Slug { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
        [JsonPropertyName("iconUrl")]
        public string IconUrl { get; set; }
        [JsonPropertyName("dateModified")]
        public DateTime? DateModified { get; set; }
        [JsonPropertyName("isClass")]
        public bool? IsClass { get; set; }
        [JsonPropertyName("classId")]
        public int? ClassId { get; set; }
        [JsonPropertyName("parentCategoryId")]
        public int? ParentCategoryId { get; set; }
        [JsonPropertyName("displayIndex")]
        public int? DisplayIndex { get; set; }
    }
}
