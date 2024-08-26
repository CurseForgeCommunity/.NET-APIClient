using System.Text.Json.Serialization;

namespace CurseForge.APIClient.Models
{
    public class Pagination
    {
        [JsonPropertyName("index")]
        public int Index { get; set; }
        [JsonPropertyName("pageSize")]
        public int PageSize { get; set; }
        [JsonPropertyName("resultCount")]
        public int ResultCount { get; set; }
        [JsonPropertyName("totalCount")]
        public long TotalCount { get; set; }
    }
}
