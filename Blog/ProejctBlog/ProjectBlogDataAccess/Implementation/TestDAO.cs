using Microsoft.Extensions.Options;
using ProejctBlogAPI;
using ProejctBlogAPI.Infrastructure;
using ProjectBlogDataAccess.Interfaces;
using ProjectBlogEntities;
using System.Threading.Tasks;

namespace ProjectBlogDataAccess.Implementation
{
    public class TestDAO : ITestDAO
    {
        private readonly ProjectBlogContext _context;

        public TestDAO(IOptions<AppSettings> settings)
        {
            _context = new ProjectBlogContext(settings);
        }
        public async Task AddOrUpdateDataAsync(string userId, Test test)
        {
            await _context.Test.InsertOneAsync(test);

        }
    }
}
