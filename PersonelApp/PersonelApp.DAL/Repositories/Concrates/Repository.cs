using PersonelApp.DAL.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.DAL.Repositories.Concrates
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected DbContext _context;
        private DbSet<TEntity> _dbSet;
        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            // context.Departments
            _dbSet.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _dbSet.AddRange(entities);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Remove(TEntity id)
        {
            _dbSet.Remove(id);
            _context.SaveChanges();
            
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public void Update(TEntity entity)
        {
            _context.SaveChanges();
        }
    }
}
