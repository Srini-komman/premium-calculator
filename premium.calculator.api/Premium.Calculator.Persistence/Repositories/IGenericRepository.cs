using System;
using System.Collections.Generic;
using System.Text;

namespace Premium.Calculator.Persistence.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        TEntity GetByID(int id);
        IEnumerable<TEntity> GetAll();
        void Add(TEntity entity);
        void AddRange(TEntity[] entity);
        void AddRangeAsync(List<TEntity> entity);
        void Remove(TEntity entity);
    }
}
