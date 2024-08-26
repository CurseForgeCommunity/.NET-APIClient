using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CurseForge.APIClient.Models.Files
{
    public class GetModFilesRequestBody
    {
        [JsonPropertyName("fileIds")]
        public List<int> FileIds { get; set; } = new List<int>();
    }
}
