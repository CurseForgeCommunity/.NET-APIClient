using System.Collections.Generic;

namespace CurseForge.APIClient.Models.Mods
{
    public class GetFeaturedModsRequestBody
    {
        public int GameId { get; set; }
        public List<int> ExcludedModIds { get; set; } = new List<int>();
        public uint? GameVersionTypeId { get; set; }
    }
}
