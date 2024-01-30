using System.Collections.Generic;

namespace CurseForge.APIClient.Models.Games
{
    public class GameVersionsByType2
    {
        public int Type { get; set; }
        public List<GameVersion> Versions { get; set; } = new List<GameVersion>();
    }
}
