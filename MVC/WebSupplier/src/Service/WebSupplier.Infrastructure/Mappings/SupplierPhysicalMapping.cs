using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebSupplier.Domain.Models;

namespace WebSupplier.Infrastructure.Mappings
{
    public class SupplierPhysicalMapping : IEntityTypeConfiguration<SupplierPhysical>
    {
        public void Configure(EntityTypeBuilder<SupplierPhysical> builder)
        {            
            

            builder.Property(x => x.Cpf)
                
                .HasColumnType("varchar(11)");
        }
    }
}
