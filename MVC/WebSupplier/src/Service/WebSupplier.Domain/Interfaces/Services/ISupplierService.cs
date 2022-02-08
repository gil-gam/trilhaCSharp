using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebSupplier.Domain.Models;

namespace WebSupplier.Domain.Interfaces.Services
{

    public interface ISupplierService : IServiceBase<Supplier>
    {
        Task Insert(Supplier supplier);
        Task Update(Supplier supplier);

        Task<IEnumerable<Supplier>> ToList();
        Task<IEnumerable<Supplier>> ToListAndProduct();
        Task Delete(Guid id);
    }


}
