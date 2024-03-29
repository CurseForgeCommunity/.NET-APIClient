﻿using System.Collections.Generic;

namespace CurseForge.APIClient.Models.Fingerprints
{
    public class GetFuzzyMatchesRequestBody
    {
        public int GameId { get; set; }
        public List<FolderFingerprint> Fingerprints { get; set; } = new List<FolderFingerprint>();
    }
}
