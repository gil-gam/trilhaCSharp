using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebSupplier.Domain.Models;

namespace WebSupplier.Domain.Interfaces.Services
{
    public interface ICategoryService : IServiceBase<Category>
    {
        Task Insert(Category category);
        Task Update(Category category);
        Task Delete(Guid id);
        Task<IEnumerable<Category>> ToList();
    }
}
