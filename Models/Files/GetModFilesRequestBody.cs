using System.Collections.Generic;

namespace CurseForge.APIClient.Models.Files
{
    public class GetModFilesRequestBody
    {
        public List<int> FileIds { get; set; } = new List<int>();
    }
}
