using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CurseForge.APIClient.Models.Mods
{
    public class FeaturedModsResponse
    {
        [JsonPropertyName("featured")]
        public List<Mod> Featured { get; set; } = new List<Mod>();
        [JsonPropertyName("popular")]
        public List<Mod> Popular { get; set; } = new List<Mod>();
        [JsonPropertyName("recentlyUpdated")]
        public List<Mod> RecentlyUpdated { get; set; } = new List<Mod>();
    }
}
