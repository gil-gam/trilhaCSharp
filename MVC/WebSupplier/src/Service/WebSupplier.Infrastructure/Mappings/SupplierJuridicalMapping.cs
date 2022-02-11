using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebSupplier.Domain.Models;

namespace WebSupplier.Infrastructure.Mappings
{
    public class SupplierJuridicalMapping : IEntityTypeConfiguration<SupplierJuridical>
    {
        public void Configure(EntityTypeBuilder<SupplierJuridical> builder)
        {                       
            builder.Property(x => x.Cnpj)
            .IsRequired()
            .HasColumnType("varchar(14)");
        }
    }
}
