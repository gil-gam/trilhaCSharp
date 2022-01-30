using System.Collections.Generic;
using System.Threading.Tasks;
using WebSupplier.Domain.Models;

namespace WebSupplier.Domain.Interfaces
{
    public interface ISupplierPhysicalService : IRepositoryBase<SupplierPhysical>
    {
        Task<IEnumerable<ISupplierPhysicalRepository>> ToList();

        //Task AddSupplierPhysical(SupplierPhysical supplierPhysical);
    }
}
