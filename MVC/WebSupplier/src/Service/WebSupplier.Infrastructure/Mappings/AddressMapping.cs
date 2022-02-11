using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebSupplier.Domain.Models;

namespace WebSupplier.Infrastructure.Mappings
{
    public class AddressMapping : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.ZipCode)
                .HasColumnType("varchar(8)");

            builder.Property(x => x.Street);

            builder.Property(x => x.Number)
                .HasColumnType("varchar(10)");

            builder.Property(x => x.City);

            builder.Property(x => x.State)
            .HasColumnType("char(2)");

            builder.ToTable("TB_Address");
        }
    }
}
