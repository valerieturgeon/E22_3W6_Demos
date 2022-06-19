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
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<AuthorDetail> AuthorDetail { get; set; }
        public DbSet<AuthorBook> AuthorBook { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Configuration fluent API

            //composite key
            modelBuilder.Entity<AuthorBook>().HasKey(ba => new { ba.Author_Id, ba.Book_Id });

            //Générer des données de départ
            modelBuilder.GenerateData();
        }
    }
}
