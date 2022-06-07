using Microsoft.EntityFrameworkCore;
using MovieLand_Models;

namespace MovieLand_DataAccess.Data
{
    public class MovieLandDbContext : DbContext
    {
        public MovieLandDbContext(DbContextOptions<MovieLandDbContext> options) : base(options) 
        { 
        }

        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            if (modelBuilder == null)
                return;

            modelBuilder.Entity<MovieGenre>().HasKey(b => new { b.MovieId, b.GenreId });
            modelBuilder.Entity<MovieLanguage>().HasKey(b => new { b.MovieId, b.LanguageId });
            modelBuilder.Entity<MovieCast>().HasKey(b => new { b.MovieId, b.ActorId });

            modelBuilder.GenerateData();
        }
    }
}
