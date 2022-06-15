using CrazyBooks_Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyBooks_DataAccess.Data
{
    public class CrazyBooksDbContext:DbContext
    {
        public CrazyBooksDbContext(DbContextOptions<CrazyBooksDbContext> options) : base(options)
        {

        }
        //public DbSet<NomClasseModele> NomDansBD { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<Book> Book { get; set; }

    }
}
