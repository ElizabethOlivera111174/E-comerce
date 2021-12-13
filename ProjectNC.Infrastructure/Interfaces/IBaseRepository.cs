using ProjectNC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProjectNC.Infrastructure.Interfaces
{
    public interface IBaseRepository<T> where T : EntityBase
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task Insert(T entity);
        Task Delete(int id);
        Task Update(T entity);
        bool EntityExists(int id);
        Task<IEnumerable<T>> FindByCondition(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);

    }
}
