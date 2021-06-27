using Microsoft.Extensions.Options;
using MongoDB.Driver;
using ProjectBlogEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProejctBlogAPI.Infrastructure
{
    public class ProjectBlogContext
    {
        private readonly IMongoDatabase _database = null;

        public ProjectBlogContext(IOptions<AppSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
                _database = client.GetDatabase(settings.Value.Database);
        }

        public IMongoCollection<Test> Test
        {
            get
            {
                return _database.GetCollection<Test>("Test");
            }
        }
    }
}
