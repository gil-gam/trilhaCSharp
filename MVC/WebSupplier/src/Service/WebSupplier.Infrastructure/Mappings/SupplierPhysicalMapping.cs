using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebSupplier.Domain.Models;

namespace WebSupplier.Infrastructure.Mappings
{
    class SupplierPhysicalMapping : IEntityTypeConfiguration<SupplierPhysical>
    {
        public void Configure(EntityTypeBuilder<SupplierPhysical> builder)
        {
           
            builder.Property(x => x.FullName)
                .IsRequired()
                .HasColumnType("varchar(300)");

            builder.Property(x => x.Cpf)
                .IsRequired()
                .HasColumnType("varchar(12)");

            builder.ToTable("TB_SupplierPhysical");
        }
    }
}
