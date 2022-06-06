using CrazyBooks_DataAccess;
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
  public class AuthorDetailRepository : Repository<AuthorDetail>, IAuthorDetailRepository
  {
    private readonly CrazyBooksDbContext _db;

    public AuthorDetailRepository(CrazyBooksDbContext db) : base(db)
    {
      _db = db;
    }

    public void Update(AuthorDetail authorDetail)
    {
      _db.Update(authorDetail);
    }
  }
}
