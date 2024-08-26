using CurseForge.APIClient.Models;
using System.Threading.Tasks;

namespace CurseForge.APIClient
{
    public partial class ApiClient
    {
        public async Task<GenericListResponse<Category>> GetCategoriesAsync(int? gameId = null, int? classId = null, bool? classesOnly = null) =>
            await GetList<Category>("/v1/categories",
                ("gameId", gameId),
                ("classId", classId),
                ("classesOnly", classesOnly)
            );
    }
}
