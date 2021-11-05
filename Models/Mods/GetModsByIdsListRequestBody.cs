using System.Collections.Generic;

namespace CurseForge.APIClient.Models.Mods
{
    public class GetModsByIdsListRequestBody
    {
        public List<long> ModIds { get; set; } = new List<long>();
    }
}
