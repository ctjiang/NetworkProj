using Microsoft.EntityFrameworkCore;

namespace MVC_Razor.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies {get; set;}
        public DbSet<Schedule> Schedules {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().ToTable("Movie");
            modelBuilder.Entity<Schedule>().ToTable("Schedule");
        }
    }
}