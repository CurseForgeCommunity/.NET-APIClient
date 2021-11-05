using System.Collections.Generic;

namespace CurseForge.APIClient.Models.Files
{
    public class GetModFilesRequestBody
    {
        public List<long> FileIds { get; set; } = new List<long>();
    }
}
