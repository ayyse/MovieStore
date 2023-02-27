using Microsoft.EntityFrameworkCore;
using MovieStore.Entities;

namespace MovieStore.DataContext
{
    public class MovieStoreDbContext : DbContext
    {
        public MovieStoreDbContext(DbContextOptions<MovieStoreDbContext> options) : base(options)
        {
            
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<ActorMovie> ActorMovies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActorMovie>().HasKey(x => new { x.ActorId, x.MovieId });
        }
    }
}
