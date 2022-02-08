using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebSupplier.Infrastructure.Data;
using WebSupplier.WebApp.Data;

namespace WebSupplier.WebApp.Configuration
{
    public static class DbContextConfiguration
    {
        public static void DbContextConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<WebSupplierContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
