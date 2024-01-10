using Products.Domain.Entities;
using Products.Domain.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Domain.Abstractions.Repositories
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        Task<List<Product>> FindProductsAsync(Guid categoryId, ProductFilter request);
        Task<Product?> FindProductByIdAsync(Guid categoryId, Guid productId, bool trackChanges);
        Task<bool> IsProductExists(Guid categoryId, Guid productId);
        void Attach(Product productToDelete);
    }
}
