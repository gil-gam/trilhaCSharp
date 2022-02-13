﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebSupplier.Infrastructure.Data;

namespace WebSupplier.Infrastructure.Migrations
{
    [DbContext(typeof(WebSupplierContext))]
    partial class WebSupplierContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebSupplier.Domain.Models.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Complement")
                        .HasColumnType("varchar(256)");

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Neighborhood")
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Number")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Reference")
                        .HasColumnType("varchar(256)");

                    b.Property<string>("State")
                        .HasColumnType("char(2)");

                    b.Property<string>("Street")
                        .HasColumnType("varchar(256)");

                    b.Property<Guid>("SupplierId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ZipCode")
                        .HasColumnType("varchar(8)");

                    b.HasKey("Id");

                    b.HasIndex("SupplierId")
                        .IsUnique();

                    b.ToTable("TB_Address");
                });

            modelBuilder.Entity("WebSupplier.Domain.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(256)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TB_Category");
                });

            modelBuilder.Entity("WebSupplier.Domain.Models.Email", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("varchar(256)");

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("SupplierId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("SupplierId")
                        .IsUnique();

                    b.ToTable("TB_Email");
                });

            modelBuilder.Entity("WebSupplier.Domain.Models.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImagePath")
                        .HasColumnType("varchar(256)");

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("TB_Image");
                });

            modelBuilder.Entity("WebSupplier.Domain.Models.Phone", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ddd")
                        .HasColumnType("char(2)");

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Number")
                        .HasColumnType("varchar(9)");

                    b.Property<Guid>("SupplierId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("SupplierId");

                    b.ToTable("TB_Phone");
                });

            modelBuilder.Entity("WebSupplier.Domain.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("BarCode")
                        .IsRequired()
                        .HasColumnType("varchar(14)");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(256)");

                    b.Property<decimal>("PricePurchase")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PriceSales")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("QuantityStock")
                        .HasColumnType("int");

                    b.Property<Guid>("SupplierId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SupplierId");

                    b.ToTable("TB_Product");
                });

            modelBuilder.Entity("WebSupplier.Domain.Models.Supplier", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("varchar(256)");

                    b.Property<string>("FantasyName")
                        .HasColumnType("varchar(256)");

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TB_Supplier");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Supplier");
                });

            modelBuilder.Entity("WebSupplier.Domain.Models.SupplierJuridical", b =>
                {
                    b.HasBaseType("WebSupplier.Domain.Models.Supplier");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("varchar(14)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("varchar(256)");

                    b.Property<DateTime>("OpenDate")
                        .HasColumnType("datetime2");

                    b.HasDiscriminator().HasValue("SupplierJuridical");
                });

            modelBuilder.Entity("WebSupplier.Domain.Models.SupplierPhysical", b =>
                {
                    b.HasBaseType("WebSupplier.Domain.Models.Supplier");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("varchar(11)");

                    b.Property<string>("FullName")
                        .HasColumnType("varchar(256)");

                    b.HasDiscriminator().HasValue("SupplierPhysical");
                });

            modelBuilder.Entity("WebSupplier.Domain.Models.Address", b =>
                {
                    b.HasOne("WebSupplier.Domain.Models.Supplier", "Supplier")
                        .WithOne("Address")
                        .HasForeignKey("WebSupplier.Domain.Models.Address", "SupplierId")
                        .IsRequired();
                });

            modelBuilder.Entity("WebSupplier.Domain.Models.Email", b =>
                {
                    b.HasOne("WebSupplier.Domain.Models.Supplier", "Supplier")
                        .WithOne("Email")
                        .HasForeignKey("WebSupplier.Domain.Models.Email", "SupplierId")
                        .IsRequired();
                });

            modelBuilder.Entity("WebSupplier.Domain.Models.Image", b =>
                {
                    b.HasOne("WebSupplier.Domain.Models.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .IsRequired();
                });

            modelBuilder.Entity("WebSupplier.Domain.Models.Phone", b =>
                {
                    b.HasOne("WebSupplier.Domain.Models.Supplier", "Supplier")
                        .WithMany("Phones")
                        .HasForeignKey("SupplierId")
                        .IsRequired();
                });

            modelBuilder.Entity("WebSupplier.Domain.Models.Product", b =>
                {
                    b.HasOne("WebSupplier.Domain.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .IsRequired();

                    b.HasOne("WebSupplier.Domain.Models.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
