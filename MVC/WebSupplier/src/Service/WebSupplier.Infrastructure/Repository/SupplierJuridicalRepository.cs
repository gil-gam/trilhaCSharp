using WebSupplier.Domain.Interfaces;
using WebSupplier.Domain.Models;
using WebSupplier.Infrastructure.Data;

namespace WebSupplier.Infrastructure.Repository
{
    public class SupplierJuridicalRepository : RepositoryBase<SupplierJuridical>, ISupplierJuridicalRepository
    {
        public SupplierJuridicalRepository(WebSupplierContext context) : base(context)
        {

        }
    }
}
