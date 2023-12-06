using Microsoft.EntityFrameworkCore.Query;
using ResumeBuilder.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Persistence
{
    public interface IRepository<TEntity, TKey> where TEntity : class, IEntity<TKey> where TKey : IComparable
    {
        void Create(TEntity entity);
        void Edit(TEntity entity);
        void Delete(TKey id);
        TEntity GetById(TKey id);
        IList<TEntity> GetAll();
        IList<TEntity> GetAll(Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> includes);
        bool Save();

    }
}
