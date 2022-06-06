using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CrazyBooks_DataAccess.Repository.IRepository
{
  // Ce doit être une interface générique <T> (T pour s'adapter au type d'objet classe ) publique
  public interface IRepository<T> where T : class
  {
    // Les méthodes devant être implantées dans les repositories

    T Get(int id);

    IEnumerable<T> GetAll(
      Expression<Func<T, bool>> filter = null,
      Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
      string includeProperties = null,
      bool isTracking = true
      );


    // Retourne le 1er seulement
    T FirstOrDefault(
      Expression<Func<T, bool>> filter = null,
      string includeProperties = null,
      bool isTracking = true
      );

    void Add(T entity);

    void Remove(T entity);

    void RemoveRange(IEnumerable<T> entity);

  }
}
