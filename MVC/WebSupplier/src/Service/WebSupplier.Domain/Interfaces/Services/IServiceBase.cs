using System;
using System.Threading.Tasks;
using WebSupplier.Domain.Models;

namespace WebSupplier.Domain.Interfaces.Services
{
    public interface IServiceBase<T> : IDisposable where T : Entity
    {
        Task<PaginationModel<T>> Pagination(int page, int size, string query = null);
        Task<T> FindById(Guid id);
    }
}
