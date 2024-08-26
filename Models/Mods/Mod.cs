using CurseForge.APIClient.Models.Files;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CurseForge.APIClient.Models.Mods
{
    public class Mod
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("gameId")]
        public int GameId { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("slug")]
        public string Slug { get; set; }
        [JsonPropertyName("links")]
        public ModLinks Links { get; set; }
        [JsonPropertyName("summary")]
        public string Summary { get; set; }
        [JsonPropertyName("status")]
        public ModStatus Status { get; set; }
        [JsonPropertyName("downloadCount")]
        public double DownloadCount { get; set; }
        [JsonPropertyName("isFeatured")]
        public bool IsFeatured { get; set; }
        [JsonPropertyName("primaryCategoryId")]
        public int PrimaryCategoryId { get; set; }
        [JsonPropertyName("categories")]
        public List<Category> Categories { get; set; } = new List<Category>();
        [JsonPropertyName("classId")]
        public int? ClassId { get; set; }
        [JsonPropertyName("authors")]
        public List<ModAuthor> Authors { get; set; } = new List<ModAuthor>();
        [JsonPropertyName("logo")]
        public ModAsset Logo { get; set; }
        [JsonPropertyName("screenshots")]
        public List<ModAsset> Screenshots { get; set; } = new List<ModAsset>();
        [JsonPropertyName("mainFileId")]
        public int MainFileId { get; set; }
        [JsonPropertyName("latestFiles")]
        public List<File> LatestFiles { get; set; } = new List<File>();
        [JsonPropertyName("latestFilesIndexes")]
        public List<FileIndex> LatestFilesIndexes { get; set; } = new List<FileIndex>();
        [JsonPropertyName("dateCreated")]
        public DateTimeOffset DateCreated { get; set; }
        [JsonPropertyName("dateModified")]
        public DateTimeOffset DateModified { get; set; }
        [JsonPropertyName("dateReleased")]
        public DateTimeOffset DateReleased { get; set; }
        [JsonPropertyName("allowModDistribution")]
        public bool? AllowModDistribution { get; set; }
        [JsonPropertyName("gamePopularityRank")]
        public int GamePopularityRank { get; set; }
        [JsonPropertyName("isAvailable")]
        public bool IsAvailable { get; set; }
        [JsonPropertyName("thumbsUpCount")]
        public int ThumbsUpCount { get; set; }
        [JsonPropertyName("rating")]
        public double? Rating { get; set; }
    }
}
