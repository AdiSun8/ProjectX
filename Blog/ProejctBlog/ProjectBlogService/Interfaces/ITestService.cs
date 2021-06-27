using ProjectBlogEntities;
using System.Threading.Tasks;

namespace ProjectBlogService.Interfaces
{
    public interface ITestService
    {
        //adding comment
        Task AddOrUpdateDataAsync(string userId, Test locRequest);

    }
}
