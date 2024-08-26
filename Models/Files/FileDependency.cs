using System.Text.Json.Serialization;

namespace CurseForge.APIClient.Models.Files
{
    public class FileDependency
    {
        [JsonPropertyName("modId")]
        public int ModId { get; set; }
        [JsonPropertyName("relationType")]
        public FileRelationType RelationType { get; set; }
    }
}
