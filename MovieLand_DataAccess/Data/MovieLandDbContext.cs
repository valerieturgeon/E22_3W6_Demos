using Microsoft.EntityFrameworkCore;
using MovieLand_Models;

namespace MovieLand_DataAccess.Data
{
    public class MovieLandDbContext : DbContext
    {
        public MovieLandDbContext(DbContextOptions<MovieLandDbContext> options) : base(options) 
        { 
        }

        public virtual DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            if (modelBuilder == null)
                return;

            modelBuilder.GenerateData();
        }
    }
}
