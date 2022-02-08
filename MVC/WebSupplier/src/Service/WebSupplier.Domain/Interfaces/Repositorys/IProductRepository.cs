using System.Collections.Generic;
using System.Threading.Tasks;
using WebSupplier.Domain.Models;

namespace WebSupplier.Domain.Interfaces.Repositorys
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        Task RemoveRangeImage(List<Image> images);
        Task InsertImageRanger(IReadOnlyCollection<Image> images);
    }
}
