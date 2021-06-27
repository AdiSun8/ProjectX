using ProjectBlogDataAccess.Interfaces;
using ProjectBlogEntities;
using ProjectBlogService.Interfaces;
using System;
using System.Threading.Tasks;

namespace ProjectBlogService.Implementation
{
    public class TestService: ITestService
    {
        private readonly ITestDAO _testRepository;

        public TestService(
            ITestDAO testRepository
            )
        {
            _testRepository = testRepository ?? throw new ArgumentNullException(nameof(testRepository));
        }

        public async Task AddOrUpdateDataAsync(string userId, Test locRequest)
        {
            try
            {
                await _testRepository.AddOrUpdateDataAsync(userId, locRequest);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
