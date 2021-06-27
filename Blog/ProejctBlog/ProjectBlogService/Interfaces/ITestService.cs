using ProjectBlogEntities;
using System.Threading.Tasks;

namespace ProjectBlogService.Interfaces
{
    public interface ITestService
    {
        Task AddOrUpdateDataAsync(string userId, Test locRequest);

    }
}
