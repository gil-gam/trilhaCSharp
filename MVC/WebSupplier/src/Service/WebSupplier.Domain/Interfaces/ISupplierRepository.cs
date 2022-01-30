using System.Collections.Generic;
using System.Threading.Tasks;
using WebSupplier.Domain.Models;
using System.Linq.Expressions;
using System;

namespace WebSupplier.Domain.Interfaces
{
    public interface ISupplierRepository : IRepositoryBase<Supplier>
    {

    }

    public interface ISupplierPhysicalRepository : IRepositoryBase<SupplierPhysical>
    {
        Task<IEnumerable<SupplierPhysical>> ToList();
    }

    public interface ISupplierJuridicalRepository : IRepositoryBase<SupplierJuridical>
    {

    }

    public interface IAddressRepository : IRepositoryBase<Address>
    {

    }

    public interface ICategoryRepository : IRepositoryBase<Category>
    {

    }


    public interface IEmailRepository : IRepositoryBase<Email>
    {

    }

    public interface IImageRepository : IRepositoryBase<Image>
    {

    }

    public interface IPhoneRepository : IRepositoryBase<Phone>
    {

    }

    public interface IProductRepository : IRepositoryBase<Product>
    {

    }


}
