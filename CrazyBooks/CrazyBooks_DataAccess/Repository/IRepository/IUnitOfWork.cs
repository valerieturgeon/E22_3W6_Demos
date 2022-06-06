using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyBooks_DataAccess.Repository.IRepository
{
  public interface IUnitOfWork : IDisposable
  {
    IAuthorRepository Author { get; }
    IAuthorBookRepository AuthorBook { get; }
    IAuthorDetailRepository AuthorDetail { get; }
    IPublisherRepository Publisher { get; }
    ISubjectRepository Subject { get; }
    IBookRepository Book { get; }

    void Save();
  }
}
