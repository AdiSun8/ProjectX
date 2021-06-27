using Microsoft.Extensions.DependencyInjection;

namespace ProejctBlogAPI.Infrastructure.Services
{
    public static class RegisterServices
    {
        public static IServiceCollection registerServices(this IServiceCollection services)
        {
            //services.AddTransient<ITestDAO,TesDao>
            return services;
        }
    }
}
