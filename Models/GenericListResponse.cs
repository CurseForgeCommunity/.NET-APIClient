using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CurseForge.APIClient.Models
{
    public class GenericListResponse<T>
    {
        [JsonPropertyName("data")]
        public List<T> Data { get; set; } = new List<T>();
        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; set; }
        [JsonIgnore]
        public ErrorResponse Error { get; set; }
    }
}
