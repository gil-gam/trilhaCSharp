using WebSupplier.Domain.Interfaces;
using WebSupplier.Domain.Models;
using WebSupplier.Infrastructure.Data;

namespace WebSupplier.Infrastructure.Repository
{
    public class AddressRepository : RepositoryBase<Address>, IAddressRepository
    {
        public AddressRepository(WebSupplierContext context) : base(context)
        {

        }
    }
}
