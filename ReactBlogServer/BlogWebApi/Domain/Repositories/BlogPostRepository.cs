using BlogWebApi.Domain.Models;
using MongoDB.Driver;

namespace BlogWebApi.Domain.Repositories
{
    public class BlogPostRepository
    {
        private readonly IMongoCollection<BlogPost> _collection;

        public BlogPostRepository(IMongoClient client)
        {
            var database = client.GetDatabase("blog");
            _collection = database.GetCollection<BlogPost>("posts");
        }

    }
}
