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
        public DbSet<COVID19.Models.Usuarios> Usuarios { get; set; }

       
    }
}