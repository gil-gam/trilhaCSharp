using System;
using System.Threading.Tasks;
using WebSupplier.Domain.Models;

namespace WebSupplier.Domain.Interfaces.Services
{
    public interface IProductService : IServiceBase<Product>
    {
        Task Insert(Product product);
        Task Delete(Guid id);
        Task Update(Product product);
    }


}
