using CurseForge.APIClient.Models;
using System.Threading.Tasks;

namespace CurseForge.APIClient
{
    public partial class ApiClient
    {
        public async Task<GenericListResponse<Category>> GetCategoriesAsync(int? gameId = null, int? classId = null)
        {
            return await GET<GenericListResponse<Category>>("/v1/categories", ("gameId", gameId), ("classId", classId));
        }
    }
}
