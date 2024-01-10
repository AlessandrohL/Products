using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Infrastructure.Persistence.Seed
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            var categoryId = new Guid("7FF68ED0-6E75-4452-B0D0-836A2AD6527C");

            builder.HasData(new List<Product>
            {
						new()
						{
							Id = Guid.NewGuid(),
							Name = "Notebook Modelo A",
							Description = "Un potente notebook para uso general.",
							Price = 999.99m,
							StockQuantity = 10,
							CategoryId = categoryId
						},
						new()
						{
							Id = Guid.NewGuid(),
							Name = "Notebook Modelo B",
							Description = "Perfecto para tareas profesionales y de diseño.",
							Price = 1299.99m,
							StockQuantity = 8,
							CategoryId = categoryId
						},
						new()
						{
							Id = Guid.NewGuid(),
							Name = "Notebook Modelo C",
							Description = "Ultra delgado y liviano, ideal para viajes.",
							Price = 799.99m,
							StockQuantity = 15,
							CategoryId = categoryId
						},
						new()
						{
							Id = Guid.NewGuid(),
							Name = "Notebook Modelo D",
							Description = "Gran rendimiento para gamers y diseñadores.",
							Price = 1499.99m,
							StockQuantity = 5,
							CategoryId = categoryId
						},
						new()
						{
							Id = Guid.NewGuid(),
							Name = "Notebook Modelo E",
							Description = "Opciones de conectividad avanzada y gran duración de batería.",
							Price = 1099.99m,
							StockQuantity = 12,
							CategoryId = categoryId
						},
						new ()
						{
							Id = Guid.NewGuid(),
							Name = "Notebook Modelo F",
							Description = "Ideal para estudiantes y uso diario.",
							Price = 599.99m,
							StockQuantity = 20,
							CategoryId = categoryId
						},
						new ()
						{
							Id = Guid.NewGuid(),
							Name = "Notebook Modelo G",
							Description = "Pantalla táctil y diseño elegante.",
							Price = 899.99m,
							StockQuantity = 18,
							CategoryId = categoryId
						},
						new ()
						{
							Id = Guid.NewGuid(),
							Name = "Notebook Modelo H",
							Description = "Potente rendimiento con tarjeta gráfica dedicada.",
							Price = 1199.99m,
							StockQuantity = 7,
							CategoryId = categoryId
						},
						new ()
						{
							Id = Guid.NewGuid(),
							Name = "Notebook Modelo I",
							Description = "Gran capacidad de almacenamiento para profesionales creativos.",
							Price = 1399.99m,
							StockQuantity = 10,
							CategoryId = categoryId
						},
						new ()
						{
							Id = Guid.NewGuid(),
							Name = "Notebook Modelo J",
							Description = "Diseñado para ejecutar múltiples aplicaciones simultáneamente.",
							Price = 999.99m,
							StockQuantity = 15,
							CategoryId = categoryId
						},
						new ()
						{
							Id = Guid.NewGuid(),
							Name = "Notebook Modelo K",
							Description = "Pantalla de alta resolución y rendimiento rápido.",
							Price = 1299.99m,
							StockQuantity = 12,
							CategoryId = categoryId
						},
						new()
						{
							Id = Guid.NewGuid(),
							Name = "Notebook Modelo L",
							Description = "Duración de batería extendida para usuarios en movimiento.",
							Price = 899.99m,
							StockQuantity = 15,
							CategoryId = categoryId
						},
						new ()
						{
							Id = Guid.NewGuid(),
							Name = "Notebook Modelo M",
							Description = "Innovador diseño 2 en 1 con pantalla táctil desmontable.",
							Price = 1499.99m,
							StockQuantity = 8,
							CategoryId = categoryId
						},
						new ()
						{
							Id = Guid.NewGuid(),
							Name = "Notebook Modelo N",
							Description = "Máxima portabilidad con peso ultraligero.",
							Price = 1099.99m,
							StockQuantity = 10,
							CategoryId = categoryId
						},
						new ()
						{
							Id = Guid.NewGuid(),
							Name = "Notebook Modelo O",
							Description = "Rendimiento empresarial con seguridad avanzada.",
							Price = 1599.99m,
							StockQuantity = 6,
							CategoryId = categoryId
						}
            });
        }
    }
}
