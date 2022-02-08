using AutoMapper;
using WebSupplier.Domain.Models;
using WebSupplier.WebApp.Models;
using WebSupplier.WebApp.Models.Category;
using WebSupplier.WebApp.Models.Product;
using WebSupplier.WebApp.Models.Supplier;

namespace WebSupplier.WebApp.Configuration
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {            
            CreateMap<NewCategoryViewModel, Category>();
            CreateMap<Category, EditCategoryViewModel>().ReverseMap();
            CreateMap<Category, CategoryViewModel>();
            CreateMap<Category, DetailsCategoryViewModel>();
            CreateMap<Category, DeleteCategoryViewModel>();

            CreateMap<PaginationModel<Category>, PaginationViewModel<CategoryViewModel>>();

            CreateMap<SupplierJuridical, DeleteCategoryViewModel>();
            CreateMap<SupplierPhysical, DeleteCategoryViewModel>();
            CreateMap<NewOrEditSupplierViewModel, SupplierJuridical>().ReverseMap();
            CreateMap<NewOrEditSupplierViewModel, SupplierPhysical>().ReverseMap();
            CreateMap<SupplierPhysical, SupplierViewModel>();
            CreateMap<SupplierJuridical, SupplierViewModel>();

            
            
            CreateMap<AddressViewModel, Address>().ReverseMap();
            CreateMap<EmailViewModel, Email>().ReverseMap();
            CreateMap<PhoneViewModel, Phone>().ReverseMap();

            CreateMap<PaginationModel<Supplier>, PaginationViewModel<SupplierViewModel>>().ReverseMap();

            
            CreateMap<Product, ProductViewModel>();            
            CreateMap<NewProductViewModel, Product>();
            CreateMap<NewImageViewModel, Image>();            
            CreateMap<Image, ImageViewModel>();

            CreateMap<EditProductViewModel, Product>().ReverseMap();
            CreateMap<EditImageViewModel, Image>().ReverseMap();

            CreateMap<PaginationModel<Product>, PaginationViewModel<ProductViewModel>>().ReverseMap();

           
            
        }
    }
}
