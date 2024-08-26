using System.Text.Json.Serialization;

namespace CurseForge.APIClient.Models
{
    public class GenericResponse<T>
    {
        [JsonPropertyName("data")]
        public T Data { get; set; }
        [JsonIgnore]
        public ErrorResponse Error { get; set; }
    }
}
