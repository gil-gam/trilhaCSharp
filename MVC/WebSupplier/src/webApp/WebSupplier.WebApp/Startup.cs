using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebSupplier.Domain.Interfaces;
using WebSupplier.Domain.Interfaces.Repositorys;
using WebSupplier.Domain.Interfaces.Services;
using WebSupplier.Domain.Services;
using WebSupplier.Infrastructure.Data;
using WebSupplier.Infrastructure.Repository;
using WebSupplier.WebApp.Configuration;
using WebSupplier.WebApp.Extensions.Background;

namespace WebSupplier.WebApp
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IHostEnvironment hostEnvironment)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(hostEnvironment.ContentRootPath)
                .AddJsonFile("appsettings.json", true, true)
                .AddJsonFile($"appsettings.{hostEnvironment.EnvironmentName}.json", true, true)
                .AddEnvironmentVariables();

            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllersWithViews();

            services.AddDbContext<WebSupplierContext>(x => x.UseSqlServer(Configuration.GetConnectionString("MyConnectionString")));

            services.AddScoped<ISupplierRepository, SupplierRepository>();
            services.AddScoped<ISupplierService, SupplierService>();
            services.AddScoped<WebSupplierContext>();

            services.AddAutoMapper(typeof(Startup));

            services.WebAppServiceConfig();

            services.IdentityMyConfig();
            services.DbContextConfig(Configuration);
            services.InjectionConfig();

            services.AddScoped<INotificationService, NotificationService>();
            services.AddHostedService<Background>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.WebAppConfig(env);
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseCors();
            app.UseAuthorization();
            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

        }

    }
}
