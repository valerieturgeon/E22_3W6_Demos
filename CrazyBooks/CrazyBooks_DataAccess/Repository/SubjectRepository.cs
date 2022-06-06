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
  public class SubjectRepository : Repository<Subject>, ISubjectRepository
  {
    private readonly CrazyBooksDbContext _db;

    public SubjectRepository(CrazyBooksDbContext db) : base(db)
    {
      _db = db;
    }

    public void Update(Subject subject)
    {
      _db.Update(subject);
    }
  }
}
