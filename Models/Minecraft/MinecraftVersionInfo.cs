using CurseForge.APIClient.Models.Enums;
using System;

namespace CurseForge.APIClient.Models.Minecraft
{
    public class MinecraftVersionInfo
    {
        public int Id { get; set; }
        public int GameVersionId { get; set; }
        public string VersionString { get; set; }
        public string JarDownloadUrl { get; set; }
        public string JsonDownloadUrl { get; set; }
        public bool Approved { get; set; }
        public DateTimeOffset DateModified { get; set; }
        public int GameVersionTypeId { get; set; }
        public CoreGameVersionStatus GameVersionStatus { get; set; }
        public CoreGameVersionTypeStatus GameVersionTypeStatus { get; set; }
    }
}
