using CurseForge.APIClient.Models.Games;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CurseForge.APIClient.Models.Files
{
    public class File
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("gameId")]
        public int GameId { get; set; }
        [JsonPropertyName("modId")]
        public int ModId { get; set; }
        [JsonPropertyName("isAvailable")]
        public bool IsAvailable { get; set; }
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
        [JsonPropertyName("fileName")]
        public string FileName { get; set; }
        [JsonPropertyName("releaseType")]
        public FileReleaseType ReleaseType { get; set; }
        [JsonPropertyName("fileStatus")]
        public FileStatus FileStatus { get; set; }
        [JsonPropertyName("hashes")]
        public List<FileHash> Hashes { get; set; } = new List<FileHash>();
        [JsonPropertyName("fileDate")]
        public DateTimeOffset FileDate { get; set; }
        [JsonPropertyName("fileLength")]
        public long FileLength { get; set; }
        [JsonPropertyName("fileSizeOnDisk")]
        public long? FileSizeOnDisk { get; set; }
        [JsonPropertyName("downloadCount")]
        public long DownloadCount { get; set; }
        [JsonPropertyName("downloadUrl")]
        public string DownloadUrl { get; set; }
        [JsonPropertyName("gameVersions")]
        public List<string> GameVersions { get; set; } = new List<string>();
        [JsonPropertyName("sortableGameVersions")]
        public List<SortableGameVersion> SortableGameVersions { get; set; } = new List<SortableGameVersion>();
        [JsonPropertyName("dependencies")]
        public List<FileDependency> Dependencies { get; set; } = new List<FileDependency>();
        [JsonPropertyName("exposeAsAlternative")]
        public bool? ExposeAsAlternative { get; set; }
        [JsonPropertyName("parentProjectId")]
        public int? ParentProjectFileId { get; set; }
        [JsonPropertyName("alternateFileId")]
        public int? AlternateFileId { get; set; }
        [JsonPropertyName("isServerPack")]
        public bool? IsServerPack { get; set; }
        [JsonPropertyName("serverPackFileId")]
        public int? ServerPackFileId { get; set; }
        [JsonPropertyName("isEarlyAccessContent")]
        public bool? IsEarlyAccessContent { get; set; }
        [JsonPropertyName("earlyAccessEndDate")]
        public DateTimeOffset? EarlyAccessEndDate { get; set; }
        [JsonPropertyName("fileFingerprint")]
        public long FileFingerprint { get; set; }
        [JsonPropertyName("modules")]
        public List<FileModule> Modules { get; set; } = new List<FileModule>();
    }
}
