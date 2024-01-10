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
    public sealed class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            var categoryId = new Guid("7FF68ED0-6E75-4452-B0D0-836A2AD6527C");

            builder.HasData(new List<Category>
            {
                new (categoryId, "Notebooks", "Categoría de Notebooks"),
                new (Guid.NewGuid(), "Smartphones", "Categoría de Smartphones")
            }); 
        }
    }
}
