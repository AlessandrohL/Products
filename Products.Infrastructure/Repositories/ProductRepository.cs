using Microsoft.EntityFrameworkCore;
using Products.Domain.Abstractions.Repositories;
using Products.Domain.Entities;
using Products.Domain.Filters;
using Products.Domain.Pagination;
using Products.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Infrastructure.Repositories
{
    public sealed class ProductRepository
        : RepositoryBase<Product>, IProductRepository
    {
       
        public ProductRepository(ApplicationDbContext context)
            : base(context)
        { }

        public async Task<Product?> FindProductByIdAsync(
            Guid categoryId,
            Guid productId,
            bool trackChanges)
        {
            return await FindByCondition(p => 
            (p.Id == productId && p.CategoryId == categoryId), trackChanges)
                .FirstOrDefaultAsync();
        }

        public async Task<List<Product>> FindProductsAsync(Guid categoryId, ProductFilter request)
        {
            return await FindAll(trackChanges: false)
                 .Where(p => p.CategoryId == categoryId)
                 .OrderBy(p => p.Name)
                 .Paginate(request.Page, request.PageSize)
                 .ToListAsync();
        }

        public async Task<bool> IsProductExists(Guid categoryId, Guid productId)
        {
            return await FindByCondition(p => 
            (p.Id == productId && p.CategoryId == categoryId), trackChanges: false)
                .AnyAsync();
        }

        public void Attach(Product productToDelete)
        {
            _context.Attach(productToDelete);
        }
    }
}
