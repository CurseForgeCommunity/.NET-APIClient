using System.Text.Json.Serialization;

namespace CurseForge.APIClient.Models.Games
{
    public class GameVersionType
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("gameId")]
        public int GameId { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("slug")]
        public string Slug { get; set; }
        [JsonPropertyName("isSyncable")]
        public bool IsSyncable { get; set; }
        [JsonPropertyName("status")]
        public GameVersionTypeStatus Status { get; set; }
    }
}
