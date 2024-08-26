using CurseForge.APIClient.Models;
using CurseForge.APIClient.Models.Mods;
using System.Linq;
using System.Threading.Tasks;

namespace CurseForge.APIClient
{
    public partial class ApiClient
    {
        public async Task<GenericListResponse<Mod>> SearchModsAsync(
            int gameId,
            int? classId = null,
            int? categoryId = null,
            int[] categoryIds = null,
            string gameVersion = null,
            string[] gameVersions = null,
            string searchFilter = null,
            ModsSearchSortField? sortField = null,
            ModsSearchSortOrder sortOrder = ModsSearchSortOrder.Descending,
            ModLoaderType? modLoaderType = null,
            ModLoaderType[] modLoaderTypes = null,
            int? gameVersionTypeId = null,
            int? authorId = null,
            int? primaryAuthorId = null,
            string slug = null,
            int? index = null,
            int? pageSize = null
        ) =>
            await GetList<Mod>("/v1/mods/search",
                ("gameId", gameId),
                ("classId", classId),
                ("categoryId", categoryId),
                ("categoryIds", categoryIds != null ? string.Join(",", categoryIds.Take(10)) : null),
                ("gameVersion", gameVersion),
                ("gameVersions", gameVersions != null ? string.Join(",", gameVersions.Take(4)) : null),
                ("searchFilter", searchFilter),
                ("sortField", sortField),
                ("sortOrder", sortOrder == ModsSearchSortOrder.Descending ? "desc" : "asc"),
                ("modLoaderType", modLoaderType),
                ("modLoaderTypes", modLoaderTypes != null ? string.Join(",", modLoaderTypes.Take(5)) : null),
                ("gameVersionTypeId", gameVersionTypeId),
                ("authorId", authorId),
                ("primaryAuthorId", primaryAuthorId),
                ("slug", slug),
                ("index", index),
                ("pageSize", pageSize)
            );

        public async Task<GenericResponse<Mod>> GetModAsync(int modId) =>
            await GetItem<Mod>($"/v1/mods/{modId}");

        public async Task<GenericResponse<string>> GetModDescriptionAsync(int modId) =>
            await GetItem<string>($"/v1/mods/{modId}/description");

        public async Task<GenericListResponse<Mod>> GetModsByIdListAsync(GetModsByIdsListRequestBody body) =>
            await PostList<Mod>("/v1/mods", body);

        public async Task<GenericResponse<FeaturedModsResponse>> GetFeaturedModsAsync(GetFeaturedModsRequestBody body) =>
            await PostItem<FeaturedModsResponse>("/v1/mods/featured", body);
    }
}
