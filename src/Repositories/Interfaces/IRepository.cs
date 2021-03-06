using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AssignmentsNetcore.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        bool Update(T entity);
        void UpdateRange(IEnumerable<T> entities);
        T Get(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
    }
}
