using Products.Domain.Abstractions;
using Products.Domain.Abstractions.Repositories;
using Products.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Infrastructure.UnitOfWorks
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public ICategoryRepository Category { get; }
        public IProductRepository Product { get; }

        public UnitOfWork(
            ApplicationDbContext context,
            ICategoryRepository category,
            IProductRepository product)
        {
            _context = context;
            Category = category;
            Product = product;
        }
        public async Task<int> SaveChangesAsync() => await _context.SaveChangesAsync();
    }
}
