using Microsoft.EntityFrameworkCore;
using COVID19.Models;

namespace COVID19.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }
       
       public DbSet<Tips> Tips { get; set; }
       public DbSet<Comment> Comment { get; set; }
       public DbSet<COVID19.Models.ToDo> ToDo { get; set; }
       public DbSet<COVID19.Models.CommentsToDo> CommentsToDo { get; set; }
    }
}