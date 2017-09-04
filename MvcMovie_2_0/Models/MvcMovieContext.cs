using Microsoft.EntityFrameworkCore;

namespace MvcMovie_2_0.Models
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
        : base(options)
        {
        }

        public DbSet<MvcMovie_2_0.Models.Movie> Movie {get; set;}
    }
}