using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebSupplier.Domain.Models;

namespace WebSupplier.Infrastructure.Mappings
{
    class SupplierJuridicalMapping : IEntityTypeConfiguration<SupplierJuridical>
    {
        public void Configure(EntityTypeBuilder<SupplierJuridical> builder)
        {

            builder.Property(x => x.FantasyName)
                .IsRequired()
                .HasColumnType("varchar(300)");
                

            builder.Property(x => x.CompanyName)
            .IsRequired()
            .HasColumnType("varchar(300)");


            builder.Property(x => x.Cnpj)
                .IsRequired()
                .HasColumnType("varchar(14)");

            builder.ToTable("TB_SupplierJuridical");
        }
    }
}
