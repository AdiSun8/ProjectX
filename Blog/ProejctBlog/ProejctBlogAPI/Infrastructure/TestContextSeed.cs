using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using ProjectBlogEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProejctBlogAPI.Infrastructure
{
    public class TestContextSeed
    {
        private static ProjectBlogContext ctx;

        public static async Task SeedAsync(IApplicationBuilder applicationBuilder)
        {
            var config = applicationBuilder
                .ApplicationServices.GetRequiredService<IOptions<AppSettings>>();

            ctx = new ProjectBlogContext(config);

            //if (!ctx.Test.Database.GetCollection<Test>(nameof(Test)).AsQueryable().Any())
            //{
                await SetDefaultData();
            //}
        }

        private async static Task SetDefaultData()
        {
            var test = new Test()
            {
                FirstName = "Test 2",
                LastName = "Test",
            };
            
            await ctx.Test.InsertOneAsync(test);
        }
    }
}
