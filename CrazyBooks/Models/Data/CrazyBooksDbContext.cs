using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrazyBooks.Models.Data
{
  public class CrazyBooksDbContext: DbContext
  {
    public CrazyBooksDbContext(DbContextOptions<CrazyBooksDbContext> options) : base(options)
    {
      
    }
    public DbSet<Book> Book { get; set; }
    public DbSet<Subject> Subject { get; set; }
    public DbSet<Publisher> Publisher { get; set; }
    public DbSet<Author> Author { get; set; }
    public DbSet<AuthorDetail> AuthorDetail { get; set; }
  }
}
