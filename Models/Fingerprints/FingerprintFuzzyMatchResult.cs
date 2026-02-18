using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CurseForge.APIClient.Models.Fingerprints
{
    public class FingerprintFuzzyMatchResult : UnmappedCatcher
    {
        [JsonPropertyName("fuzzyMatches")]
        public List<FingerprintFuzzyMatch> FuzzyMatches { get; set; } = new List<FingerprintFuzzyMatch>();
    }
}
