using EF.Core.Repository.Interface.Repository;
using EF.Core.Repository.Manager;
using Practice.Context;
using Practice.Interfaces.Manager;
using Practice.Models;
using Practice.Repository;

namespace Practice.Manager
{
    public class PostManager : CommonManager<Post>, IPostManager
    {
        public PostManager(ApplicationDbContext _dbContext) : base(new PostRepository(_dbContext))
        {
        }

        public Post GetById(int id)
        {
           return GetFirstOrDefault(x=>id==x.Id);   
        }
    }
}
