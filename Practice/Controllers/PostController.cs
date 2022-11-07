using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practice.Context;
using Practice.Interfaces.Manager;
using Practice.Manager;
using Practice.Models;

namespace Practice.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        ApplicationDbContext _dbContext;
        IPostManager _postManager;

        //public PostController(ApplicationDbContext dbContext)
        //{
        //    _dbContext = dbContext;
        //    _postManager = new PostManager(dbContext);
        //}

        public PostController(IPostManager postManager)
        {
            _postManager = postManager;
        }

        
        [HttpGet]
        public List<Post> GetAll()
        {
           // var  posts = _dbContext.Posts.ToList();
           var posts = _postManager.GetAll().ToList();
            return posts;
        }

        [HttpGet ("{id}/{id2}")]
        public Post GetById(int id)
        {
            // var  posts = _dbContext.Posts.ToList();
            var posts = _postManager.GetById(id);
            return posts;
        }


        [HttpPost]
        public Post Add(Post post)
        {
            post.CreatedDate = DateTime.Now;
          //  _dbContext.Posts.Add(post);

            bool isSaved=_postManager.Add(post);

           // bool isSaved = _dbContext.SaveChanges() > 0;
            if(isSaved)
            {
                return post;
            }
            return null;
        }

        [HttpPut]
        public Post Edit(Post post)
        {
            bool isUpdated=_postManager.Update(post);
            if (isUpdated)
            {
                return post;
            }
            return null;
        }
    }

    
}
