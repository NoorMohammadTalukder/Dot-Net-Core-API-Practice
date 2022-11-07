using Microsoft.EntityFrameworkCore;
using Practice.Models;

namespace Practice.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Post> Posts { get; set; }
    }
}
