using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebSupplier.Domain.Models;

namespace WebSupplier.Infrastructure.Mappings
{
    class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
                        
            builder.Property(x => x.Id)
                .IsRequired();

            builder.Property(x => x.InsertDate)
             .IsRequired();

            builder.Property(x => x.UpdateTime)
             .IsRequired();

            builder.Property(x => x.Name)
            .IsRequired()
            .HasColumnType("varchar(300)");

            builder.Property(x => x.Barcode)
                .IsRequired();

            builder.Property(x => x.QuantityStock)
                .IsRequired();

            builder.Property(x => x.Active)
                .IsRequired();

            builder.Property(x => x.PriceSales)
                .IsRequired();

            builder.Property(x => x.PricePurchase)
                .IsRequired();

            builder.ToTable("TB_Product");
        }
    }
}
