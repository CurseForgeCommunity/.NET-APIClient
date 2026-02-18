using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CurseForge.APIClient.Models
{
    public class UnmappedCatcher
    {
        [JsonExtensionData]
        public Dictionary<string, JsonElement> UnmappedProperties { get; set; }
    }
}