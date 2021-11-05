using System.Collections.Generic;

namespace CurseForge.APIClient.Models.Games
{
    public class GameVersionsByType
    {
        public int Type {  get; set;}
        public List<string> Versions {  get; set; } = new List<string>();
    }
}
