using IncidentApp.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace AppNominas.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        public IncidentAppContext _context { get; set; }
        public Repository(IncidentAppContext context) 
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

       /* public void Delete(T entity)
        {
            //var data = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(entity);
        }*/

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = _context.Set<T>().Where(predicate).AsNoTracking();
            return query;
        }

        public IQueryable<T> GetAll()
        {
            IQueryable<T> query = _context.Set<T>().AsNoTracking();
            return query;
        }

        public T GetByID(int id)
        {
           var value = _context.Set<T>().Find(id);
           return value;
        }        
    }
}
