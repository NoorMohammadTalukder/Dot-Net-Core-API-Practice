using EF.Core.Repository.Repository;
using Microsoft.EntityFrameworkCore;
using Practice.Context;
using Practice.Interfaces.Repository;
using Practice.Models;

namespace Practice.Repository
{
    public class PostRepository : CommonRepository<Post>, IPostRepository
    {
        public PostRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
