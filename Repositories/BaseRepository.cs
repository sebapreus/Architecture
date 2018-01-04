using EF;
using Models;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, IBaseModel
    {
        private AppDbContext context;
        IDbSet<T> dbSet;

        public BaseRepository(AppDbContext _context)
        {
            context = _context;
            dbSet = context.Set<T>();
        }

        public void Create(T entity)
        {
            entity.InsertDate = DateTime.Now;
            entity.UpdateDate = DateTime.Now;
            dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet;
        }

        public T GetByID(int id)
        {
            return dbSet.Find(id);
        }

        public void Update(T item)
        {
            item.UpdateDate = DateTime.Now;
            context.Entry(item).State = EntityState.Modified;
        }
    }
}
