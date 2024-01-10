﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Products.Infrastructure.Persistence.Contexts;

#nullable disable

namespace Products.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Products.Domain.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<string>("Description")
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("7ff68ed0-6e75-4452-b0d0-836a2ad6527c"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Categoría de Notebooks",
                            Name = "Notebooks"
                        },
                        new
                        {
                            Id = new Guid("3aca1461-aa06-4fc0-bbe4-206fe3dd326f"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Categoría de Smartphones",
                            Name = "Smartphones"
                        });
                });

            modelBuilder.Entity("Products.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("143202df-49a3-4047-8123-8323d2243420"),
                            CategoryId = new Guid("7ff68ed0-6e75-4452-b0d0-836a2ad6527c"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Un potente notebook para uso general.",
                            Name = "Notebook Modelo A",
                            Price = 999.99m,
                            StockQuantity = 10
                        },
                        new
                        {
                            Id = new Guid("0ce1fee5-6d3d-42e6-97a9-fc0434dbd995"),
                            CategoryId = new Guid("7ff68ed0-6e75-4452-b0d0-836a2ad6527c"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Perfecto para tareas profesionales y de diseño.",
                            Name = "Notebook Modelo B",
                            Price = 1299.99m,
                            StockQuantity = 8
                        },
                        new
                        {
                            Id = new Guid("30585843-928d-4ab0-b336-6f025609266b"),
                            CategoryId = new Guid("7ff68ed0-6e75-4452-b0d0-836a2ad6527c"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Ultra delgado y liviano, ideal para viajes.",
                            Name = "Notebook Modelo C",
                            Price = 799.99m,
                            StockQuantity = 15
                        },
                        new
                        {
                            Id = new Guid("9584b0b0-ef3d-4325-a82b-0e0c83984d37"),
                            CategoryId = new Guid("7ff68ed0-6e75-4452-b0d0-836a2ad6527c"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Gran rendimiento para gamers y diseñadores.",
                            Name = "Notebook Modelo D",
                            Price = 1499.99m,
                            StockQuantity = 5
                        },
                        new
                        {
                            Id = new Guid("0bdf1c94-4f87-4b21-8e01-5a969e499a52"),
                            CategoryId = new Guid("7ff68ed0-6e75-4452-b0d0-836a2ad6527c"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Opciones de conectividad avanzada y gran duración de batería.",
                            Name = "Notebook Modelo E",
                            Price = 1099.99m,
                            StockQuantity = 12
                        },
                        new
                        {
                            Id = new Guid("128d4646-ac64-4676-8526-62c1be863157"),
                            CategoryId = new Guid("7ff68ed0-6e75-4452-b0d0-836a2ad6527c"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Ideal para estudiantes y uso diario.",
                            Name = "Notebook Modelo F",
                            Price = 599.99m,
                            StockQuantity = 20
                        },
                        new
                        {
                            Id = new Guid("d066f3e6-6171-40dc-b5d4-e5b7fc2d88cd"),
                            CategoryId = new Guid("7ff68ed0-6e75-4452-b0d0-836a2ad6527c"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Pantalla táctil y diseño elegante.",
                            Name = "Notebook Modelo G",
                            Price = 899.99m,
                            StockQuantity = 18
                        },
                        new
                        {
                            Id = new Guid("637bb560-a5f7-4d67-be3d-bcf2cbad14d6"),
                            CategoryId = new Guid("7ff68ed0-6e75-4452-b0d0-836a2ad6527c"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Potente rendimiento con tarjeta gráfica dedicada.",
                            Name = "Notebook Modelo H",
                            Price = 1199.99m,
                            StockQuantity = 7
                        },
                        new
                        {
                            Id = new Guid("1dd08833-16c3-447e-8d9e-6c9b1a9964f2"),
                            CategoryId = new Guid("7ff68ed0-6e75-4452-b0d0-836a2ad6527c"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Gran capacidad de almacenamiento para profesionales creativos.",
                            Name = "Notebook Modelo I",
                            Price = 1399.99m,
                            StockQuantity = 10
                        },
                        new
                        {
                            Id = new Guid("1584adbe-61c0-4251-83a4-40c6d207deff"),
                            CategoryId = new Guid("7ff68ed0-6e75-4452-b0d0-836a2ad6527c"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Diseñado para ejecutar múltiples aplicaciones simultáneamente.",
                            Name = "Notebook Modelo J",
                            Price = 999.99m,
                            StockQuantity = 15
                        },
                        new
                        {
                            Id = new Guid("caac1448-0ec0-4863-941e-8d096fd4f0a8"),
                            CategoryId = new Guid("7ff68ed0-6e75-4452-b0d0-836a2ad6527c"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Pantalla de alta resolución y rendimiento rápido.",
                            Name = "Notebook Modelo K",
                            Price = 1299.99m,
                            StockQuantity = 12
                        },
                        new
                        {
                            Id = new Guid("497b6377-b2e5-4fb1-934f-f86c8d7223fd"),
                            CategoryId = new Guid("7ff68ed0-6e75-4452-b0d0-836a2ad6527c"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Duración de batería extendida para usuarios en movimiento.",
                            Name = "Notebook Modelo L",
                            Price = 899.99m,
                            StockQuantity = 15
                        },
                        new
                        {
                            Id = new Guid("e044ed05-823c-4476-99d5-0022dd97ffb4"),
                            CategoryId = new Guid("7ff68ed0-6e75-4452-b0d0-836a2ad6527c"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Innovador diseño 2 en 1 con pantalla táctil desmontable.",
                            Name = "Notebook Modelo M",
                            Price = 1499.99m,
                            StockQuantity = 8
                        },
                        new
                        {
                            Id = new Guid("9f1af0ea-d586-4d6f-a5ce-4876cffdf0ea"),
                            CategoryId = new Guid("7ff68ed0-6e75-4452-b0d0-836a2ad6527c"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Máxima portabilidad con peso ultraligero.",
                            Name = "Notebook Modelo N",
                            Price = 1099.99m,
                            StockQuantity = 10
                        },
                        new
                        {
                            Id = new Guid("4061ecf4-72a4-4709-bbbe-5e1e3e128f76"),
                            CategoryId = new Guid("7ff68ed0-6e75-4452-b0d0-836a2ad6527c"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Rendimiento empresarial con seguridad avanzada.",
                            Name = "Notebook Modelo O",
                            Price = 1599.99m,
                            StockQuantity = 6
                        });
                });

            modelBuilder.Entity("Products.Domain.Entities.Product", b =>
                {
                    b.HasOne("Products.Domain.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Products.Domain.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
