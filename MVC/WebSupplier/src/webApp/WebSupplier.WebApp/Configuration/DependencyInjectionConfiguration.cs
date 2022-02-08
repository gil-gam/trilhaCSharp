using Microsoft.Extensions.DependencyInjection;
using WebSupplier.Domain.Interfaces;
using WebSupplier.Domain.Interfaces.Repositorys;
using WebSupplier.Domain.Interfaces.Services;
using WebSupplier.Domain.Services;
using WebSupplier.Infrastructure.Data;
using WebSupplier.Infrastructure.Repository;
using WebSupplier.WebApp.Extensions;

namespace WebSupplier.WebApp.Configuration
{
    public static class DependencyInjectionConfiguration
    {
        public static void InjectionConfig(this IServiceCollection services)
        {
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ISupplierRepository, SupplierRepository>();
            services.AddScoped<WebSupplierContext>();

            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ISupplierService, SupplierService>();
            services.AddScoped<INotificationService, NotificationService>();


            services.AddScoped<IImageService, ImageService>();
            services.AddScoped<Report>();
        }
    }
}
