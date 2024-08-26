using CurseForge.APIClient.Models;
using CurseForge.APIClient.Models.Games;
using System.Threading.Tasks;

namespace CurseForge.APIClient
{
    public partial class ApiClient
    {
        public async Task<GenericListResponse<Game>> GetGamesAsync(int? index = null, int? pageSize = null) =>
            await GetList<Game>(
                "/v1/games",
                ("index", index),
                ("pageSize", pageSize)
            );

        public async Task<GenericResponse<Game>> GetGameAsync(int gameId) =>
            await GetItem<Game>($"/v1/games/{gameId}");

        public async Task<GenericListResponse<GameVersionsByType>> GetGameVersionsAsync(int gameId) =>
            await GetList<GameVersionsByType>($"/v1/games/{gameId}/versions");

        public async Task<GenericListResponse<GameVersionsByType2>> GetGameVersionsAsyncV2(int gameId) =>
            await GetList<GameVersionsByType2>($"/v2/games/{gameId}/versions");

        public async Task<GenericListResponse<GameVersionType>> GetGameVersionTypesAsync(int gameId) =>
            await GetList<GameVersionType>($"/v1/games/{gameId}/version-types");
    }
}
