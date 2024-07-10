﻿// <auto-generated />
using System;
using CategoryAPI.Connection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ProductAPI.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    partial class ProductDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProductAPI.Entities.Images", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte>("Order")
                        .HasColumnType("tinyint");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Order = (byte)1,
                            Path = "https://cdn.akakce.com/z/apple/iphone-14-pro-max.jpg",
                            ProductId = 1
                        },
                        new
                        {
                            Id = 2,
                            Order = (byte)2,
                            Path = "https://cdn.akakce.com/z/apple/iphone-14-pro-max-256-gb-altin.jpg",
                            ProductId = 1
                        },
                        new
                        {
                            Id = 3,
                            Order = (byte)1,
                            Path = "https://cdn.akakce.com/z/samsung/samsung-galaxy-m32.jpg",
                            ProductId = 2
                        },
                        new
                        {
                            Id = 4,
                            Order = (byte)1,
                            Path = "https://cdn.dsmcdn.com/ty1366/product/media/images/prod/QC/20240615/17/83c73daf-a685-32fd-8748-d60e02294789/1_org_zoom.jpg",
                            ProductId = 3
                        },
                        new
                        {
                            Id = 5,
                            Order = (byte)2,
                            Path = "https://cdn.dsmcdn.com/ty1366/product/media/images/prod/QC/20240615/17/e3bfef4e-7126-3e1d-8977-8106adbd1879/1_org_zoom.jpg",
                            ProductId = 3
                        });
                });

            modelBuilder.Entity("ProductAPI.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CategoryTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoverPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<double?>("StarRate")
                        .HasColumnType("float");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CategoryTitle = "Elektronik",
                            CoverPath = "https://cdn.akakce.com/z/apple/iphone-14-pro-max.jpg",
                            CreatedDate = new DateTime(2024, 7, 9, 19, 33, 21, 624, DateTimeKind.Local).AddTicks(6170),
                            Price = 40.000m,
                            StarRate = 4.0,
                            Status = 1,
                            Title = "Iphone 14 Pro Max"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            CategoryTitle = "Elektronik",
                            CoverPath = "https://cdn.akakce.com/z/samsung/samsung-galaxy-m32.jpg",
                            CreatedDate = new DateTime(2024, 7, 9, 19, 33, 21, 624, DateTimeKind.Local).AddTicks(6200),
                            Price = 32.000m,
                            StarRate = 4.0,
                            Status = 1,
                            Title = "Galaxy M32"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            CategoryTitle = "Giyim",
                            CoverPath = "https://cdn.dsmcdn.com/ty1366/product/media/images/prod/QC/20240615/17/83c73daf-a685-32fd-8748-d60e02294789/1_org_zoom.jpg",
                            CreatedDate = new DateTime(2024, 7, 9, 19, 33, 21, 624, DateTimeKind.Local).AddTicks(6210),
                            Price = 4.500m,
                            StarRate = 4.0,
                            Status = 1,
                            Title = "Xspedd X-evo Erkek\nYazlık Motosiklet Mont Siyah"
                        });
                });

            modelBuilder.Entity("ProductAPI.Entities.Images", b =>
                {
                    b.HasOne("ProductAPI.Entities.Product", null)
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProductAPI.Entities.Product", b =>
                {
                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
