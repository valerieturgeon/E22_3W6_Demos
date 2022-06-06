using CrazyBooks_DataAccess.Data;
using CrazyBooks_DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CrazyBooks_DataAccess.Repository
{
  public class Repository<T> : IRepository<T> where T : class
  {
    // pour accéder à la BD, aux entités
    private readonly CrazyBooksDbContext _db;
    // pour faire des changements directs
    internal DbSet<T> dbset;

    public Repository(CrazyBooksDbContext db)
    {
      _db = db;
      this.dbset = _db.Set<T>();
    }

    public void Add(T entity)
    {
      dbset.Add(entity);
    }

    public T Get(int id)
    {
      return dbset.Find(id);
    }


    /* doit tenir compte que certains retournent des VM avec des where et des liens
       Exemple: IEnumerable<Product> objList = _db.Product.Include(u => u.Category).Include(u => u.ApplicationType);
    Expression<Func> permet le linq avec filter permet le where
    IOrderedQueryable... permet le orderby
    includeProperties permet le lié avec Include
    isTracking, par défaut dans EF Core, utile mais diminue la performance. Pour Retreive seulement: peut être false
  */
    public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null, bool isTracking = true)
    {
      IQueryable<T> query = dbset;
      if (filter != null)
      {
        query = query.Where(filter);
      }

      if (includeProperties != null)
      {
        foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
        {
          // reproduit: _db.Product.Include(u => u.Category).Include(u => u.ApplicationType)
          // mais passé en string
          query = query.Include(includeProp);
        }
      }

      if (orderBy != null)
      {
        query = orderBy(query);
      }

      if (!isTracking)
      {
        query = query.AsNoTracking();
      }

      return query.ToList();

    }

    public T FirstOrDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null, bool isTracking = true)
    {
      IQueryable<T> query = dbset;
      if (filter != null)
      {
        query = query.Where(filter);
      }

      if (includeProperties != null)
      {
        foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
        {
          // reproduit: _db.Product.Include(u => u.Category).Include(u => u.ApplicationType)
          // mais passé en string
          query = query.Include(includeProp);
        }
      }

      if (!isTracking)
      {
        query = query.AsNoTracking();
      }

      return query.FirstOrDefault();
    }

    public void Remove(T entity)
    {
      dbset.Remove(entity);
    }

    public void RemoveRange(IEnumerable<T> entity)
    {
      // Supprimer plusieurs lignes en même temps
      dbset.RemoveRange(entity);
    }
    
  }
}
