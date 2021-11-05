using CurseForge.APIClient.Models.Mods;

namespace CurseForge.APIClient.Models.Files
{
    public class FileIndex
    {
        public string GameVersion { get; set; }
        public int FileId { get; set; }
        public string Filename { get; set; }
        public FileReleaseType ReleaseType { get; set; }
        public int? GameVversionTypeId { get; set; }
        public ModLoaderType? ModLoader { get; set; }
    }
}
