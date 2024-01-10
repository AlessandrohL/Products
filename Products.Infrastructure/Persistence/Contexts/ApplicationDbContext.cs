using Microsoft.EntityFrameworkCore;
using Products.Domain.Entities;
using Products.Infrastructure.Persistence.Configurations;
using Products.Infrastructure.Persistence.Seed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Infrastructure.Persistence.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());

            modelBuilder.ApplyConfiguration(new CategorySeed());
            modelBuilder.ApplyConfiguration(new ProductSeed());
        }

        public DbSet<Category>? Categories { get; }
        public DbSet<Product>? Products { get; }
    }
}
