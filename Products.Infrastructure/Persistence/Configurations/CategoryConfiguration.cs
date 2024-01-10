using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Infrastructure.Persistence.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            builder.Property(c => c.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.Description)
                .HasMaxLength(70);

            builder.HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);

            builder.Property(p => p.CreatedAt)
                .HasDefaultValueSql("GETUTCDATE()");
        }
    }
}
