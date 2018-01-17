using DeltaXApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DeltaXApi
{
     class MovieContext : DbContext
    {

        public MovieContext (DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Movie> MovieList { get; set; }
        public DbSet<Models.Actor> ActorsList { get; set; }
        public DbSet<Models.Producer> ProducersList { get; set; }
        public DbSet<Models.MovieActor> MovieActor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Actor>().ToTable("Actor");
            modelBuilder.Entity<Producer>().ToTable("Producer");
            modelBuilder.Entity<Movie>().ToTable("Movie");
            //modelBuilder.Entity<Movie>().
            modelBuilder.Entity<MovieActor>().ToTable("MovieActor");
            modelBuilder.Entity<MovieActor>() 
           .HasKey(x => new {x.MovieID, x.ActorID});

       
        }
    }
}