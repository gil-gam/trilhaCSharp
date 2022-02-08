using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebSupplier.Domain.Models;

namespace WebSupplier.Infrastructure.Mappings
{
    public class EmailMapping : IEntityTypeConfiguration<Email>
    {
        public void Configure(EntityTypeBuilder<Email> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.EmailAddress)
               .IsRequired();

            builder.ToTable("TB_Email");
        }
    }
}
