using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CurseForge.APIClient.Models.Mods
{
    public class GetFeaturedModsRequestBody
    {
        [JsonPropertyName("gameId")]
        public int GameId { get; set; }
        [JsonPropertyName("excludedModIds")]
        public List<int> ExcludedModIds { get; set; } = new List<int>();
        [JsonPropertyName("gameVersionTypeId")]
        public int? GameVersionTypeId { get; set; }
    }
}
