using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebSupplier.Domain.Models;

namespace WebSupplier.Infrastructure.Data
{
    public class WebSupplierContext : DbContext
    {
        public WebSupplierContext(DbContextOptions<WebSupplierContext> options) : base(options) { }

        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<SupplierJuridical> SupplierJuridical { get; set; }
        public DbSet<SupplierPhysical> SupplierPhysical { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Phone> Phone { get; set; }
        public DbSet<Email> Email { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Image> Image { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("InsertDate") != null &&
                                                                         entry.Entity.GetType().GetProperty("UpdateDate") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("InsertDate").CurrentValue = DateTime.Now;
                    entry.Property("UpdateDate").IsModified = false;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("UpdateDate").CurrentValue = DateTime.Now;
                    entry.Property("InsertDate").IsModified = false;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(256)");

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
                relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(WebSupplierContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
