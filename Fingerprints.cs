using CurseForge.APIClient.Models;
using CurseForge.APIClient.Models.Fingerprints;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace CurseForge.APIClient
{
    public partial class ApiClient
    {
        public async Task<GenericResponse<FingerprintMatchesResult>> GetFingerprintByGameIdMatchesAsync(int gameId, GetFingerprintMatchesRequestBody body) =>
            await POST<GenericResponse<FingerprintMatchesResult>>($"/v1/fingerprints/{gameId}", body);

        public async Task<GenericResponse<FingerprintMatchesResult>> GetFingerprintMatchesAsync(GetFingerprintMatchesRequestBody body) =>
            await POST<GenericResponse<FingerprintMatchesResult>>("/v1/fingerprints", body);

        public async Task<GenericResponse<FingerprintFuzzyMatchResult>> GetFingerprintsFuzzyMatchesByGameIdAsync(int gameId, GetFuzzyMatchesRequestBody body) =>
            await POST<GenericResponse<FingerprintFuzzyMatchResult>>($"/v1/fingerprints/fuzzy/{gameId}", body);

        public async Task<GenericResponse<FingerprintFuzzyMatchResult>> GetFingerprintsFuzzyMatchesAsync(GetFuzzyMatchesRequestBody body) =>
            await POST<GenericResponse<FingerprintFuzzyMatchResult>>("/v1/fingerprints/fuzzy", body);

        public async Task<GenericResponse<FingerprintMatchesResult>> GetFingerprintMatchesForFileByGameIdAsync(int gameId, string file)
        {
            var fingerprint = GetFingerprintFromFile(file);

            return await POST<GenericResponse<FingerprintMatchesResult>>($"/v1/fingerprints/{gameId}", new GetFingerprintMatchesRequestBody
            {
                Fingerprints = new List<long> { fingerprint }
            });
        }

        public async Task<GenericResponse<FingerprintMatchesResult>> GetFingerprintMatchesForFileAsync(string file)
        {
            var fingerprint = GetFingerprintFromFile(file);

            return await POST<GenericResponse<FingerprintMatchesResult>>("/v1/fingerprints", new GetFingerprintMatchesRequestBody
            {
                Fingerprints = new List<long> { fingerprint }
            });
        }

        public long GetFingerprintFromFile(string file)
        {
            return GetFingerprintFromBytes(File.ReadAllBytes(file));
        }

        public long GetFingerprintFromBytes(byte[] fileBytes)
        {
            return MurmurHash2.Hash(MurmurHash2.NormalizeByteArray(fileBytes));
        }
    }
}
