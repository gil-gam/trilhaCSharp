using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace WebSupplier.Domain.Interfaces
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        Task<T> Find(Expression<Func<T, bool>> expression);

        Task Insert(T entity);

        Task Update(T entity);

        Task Remove(T entity);       
    }
}
