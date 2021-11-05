using System.Collections.Generic;

namespace CurseForge.APIClient.Models.Mods
{
    public class GetFeaturedModsRequestBody
    {
        public int GameId { get; set; }
        public List<long> ExcludedModIds {  get; set;} = new List<long>();
        public int? GameVersionTypeId {  get; set; }
    }
}
