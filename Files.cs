using CurseForge.APIClient.Models;
using CurseForge.APIClient.Models.Files;
using CurseForge.APIClient.Models.Mods;
using System.Threading.Tasks;

namespace CurseForge.APIClient
{
    public partial class ApiClient
    {
        public async Task<GenericResponse<File>> GetModFileAsync(int modId, int fileId) =>
            await GetItem<File>($"/v1/mods/{modId}/files/{fileId}");

        public async Task<GenericListResponse<File>> GetModFilesAsync(int modId, string gameVersion = null,
            ModLoaderType? modLoaderType = null, string gameVersionFlavor = null,
            int? index = null, int? pageSize = null) =>
            await GetList<File>($"/v1/mods/{modId}/files",
                ("gameVersion", gameVersion),
                ("modLoaderType", modLoaderType),
                ("gameVersionFlavor", gameVersionFlavor),
                ("index", index),
                ("pageSize", pageSize)
            );

        public async Task<GenericListResponse<File>> GetFilesAsync(GetModFilesRequestBody body) =>
            await PostList<File>("/v1/mods/files", body);

        public async Task<GenericResponse<string>> GetModFileChangelogAsync(int modId, int fileId) =>
            await GetItem<string>($"/v1/mods/{modId}/files/{fileId}/changelog");

        public async Task<GenericResponse<string>> GetModFileDownloadUrlAsync(int modId, int fileId) =>
            await GetItem<string>($"/v1/mods/{modId}/files/{fileId}/download-url");
    }
}
