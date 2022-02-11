using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebSupplier.Domain.Models;

namespace WebSupplier.Infrastructure.Mappings
{
    public class PhoneMapping : IEntityTypeConfiguration<Phone>
    {
        public void Configure(EntityTypeBuilder<Phone> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Ddd)
            .HasColumnType("char(2)");

            builder.Property(x => x.Number)
            .HasColumnType("varchar(9)");

            builder.ToTable("TB_Phone");
        }
    }
}
