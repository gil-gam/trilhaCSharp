using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebSupplier.Domain.Interfaces;
using WebSupplier.Domain.Models;
using WebSupplier.Infrastructure.Data;

namespace WebSupplier.Infrastructure.Repository
{
    public class SupplierPhysicalRepository : RepositoryBase<SupplierPhysical>, ISupplierPhysicalRepository
    {
        public SupplierPhysicalRepository(WebSupplierContext context) : base(context)
        {
        }

        public async Task<IEnumerable<SupplierPhysical>> ToList()
        {
            return await _dbSet.ToListAsync();
        }

    }
}
