using Piton.Infrastructure.Event;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;


namespace Piton.Infrastructure.Repositories
{
    public interface IRepository <T> where T : class, IEntity , new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
