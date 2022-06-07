using Microsoft.EntityFrameworkCore;
using MovieLand_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLand_DataAccess.Data
{
    public class MovieLandDbContext : DbContext
    {
        public MovieLandDbContext(DbContextOptions<MovieLandDbContext> options) : base(options) 
        { 
        }

        public virtual DbSet<Movie> Movies { get; set; }
    }
}
