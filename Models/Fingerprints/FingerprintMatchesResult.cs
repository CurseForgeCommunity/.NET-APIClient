using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CurseForge.APIClient.Models.Fingerprints
{
    public class FingerprintMatchesResult
    {
        [JsonPropertyName("isCacheBuilt")]
        public bool IsCacheBuilt { get; set; }
        [JsonPropertyName("exactMatches")]
        public List<FingerprintMatch> ExactMatches { get; set; } = new List<FingerprintMatch>();
        [JsonPropertyName("exactFingerprints")]
        public List<long> ExactFingerprints { get; set; } = new List<long>();
        [JsonPropertyName("partialMatches")]
        public List<FingerprintMatch> PartialMatches { get; set; } = new List<FingerprintMatch>();
        [JsonPropertyName("partialMatchFingerprints")]
        public object PartialMatchFingerprints { get; set; }
        [JsonPropertyName("additionalProperties")]
        public List<long> AdditionalProperties { get; set; } = new List<long>();
        [JsonPropertyName("installedFingerprints")]
        public List<long> InstalledFingerprints { get; set; } = new List<long>();
        [JsonPropertyName("unmatchedFingerprints")]
        public List<long> UnmatchedFingerprints { get; set; } = new List<long>();
    }
}
