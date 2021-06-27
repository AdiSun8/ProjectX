using ProjectBlogEntities;
using System.Threading.Tasks;

namespace ProjectBlogDataAccess.Interfaces
{
    public interface ITestDAO
    {
        public Task AddOrUpdateDataAsync(string userId, Test test);
    }
}
