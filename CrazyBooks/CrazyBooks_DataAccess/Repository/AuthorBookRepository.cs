using CrazyBooks_DataAccess.Data;
using CrazyBooks_DataAccess.Repository;
using CrazyBooks_DataAccess.Repository.IRepository;
using CrazyBooks_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyBook_DataAccess.Repository
{
  public class AuthorBookRepository : Repository<AuthorBook>, IAuthorBookRepository
  {
    private readonly CrazyBooksDbContext _db;

    public AuthorBookRepository(CrazyBooksDbContext db) : base(db)
    {
      _db = db;
    }

    public void Update(AuthorBook authorBook)
    {
      _db.Update(authorBook);

    }
  }
}
