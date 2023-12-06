using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using ResumeBuilder.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Persistence
{
   
    public abstract class Repository<TEntity, TKey> : 
        IRepository<TEntity, TKey> where TEntity : class, IEntity<TKey> where TKey : IComparable
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _dbSet;
        public Repository(DbContext context) 
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public void Create(TEntity entity)
        {
            _dbSet.Add(entity);

        }

        public void Delete(TKey id)
        {
            _dbSet.Remove(GetById(id));
        }

        public void Edit(TEntity entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public TEntity GetById(TKey id)
        {
            return _dbSet.Find(id);
        }
        public IList<TEntity> GetAll(Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> includes) 
        {
            IQueryable<TEntity> query = _dbSet.AsQueryable();
            if (includes != null)
            {
                query = includes(query);
            }
            return query.ToList();
        }
        public IList<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }
        public bool Save()
        {
            return _context.SaveChanges()>0;
        }
    }
}
