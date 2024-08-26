using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CurseForge.APIClient.Models.Mods
{
    public class GetModsByIdsListRequestBody
    {
        [JsonPropertyName("modIds")]
        public List<int> ModIds { get; set; } = new List<int>();
        [JsonPropertyName("filterPcOnly")]
        public bool FilterPcOnly { get; set; } = false;
    }
}
