namespace CurseForge.APIClient.Models.Games
{
    public class GameVersionType
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public bool IsSyncable { get; set; }
        public GameVersionTypeStatus Status { get; set; }
    }
}
