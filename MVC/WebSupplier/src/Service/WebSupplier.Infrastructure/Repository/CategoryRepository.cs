using WebSupplier.Domain.Interfaces.Repositorys;
using WebSupplier.Domain.Models;
using WebSupplier.Infrastructure.Data;
using WebSupplier.Infrastructure.Repository;

namespace WebSupplier.Infrastructure.Repository
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(WebSupplierContext context) : base(context)
        {
        }
    }


}
