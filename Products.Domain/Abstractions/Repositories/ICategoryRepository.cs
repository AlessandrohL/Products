using Products.Domain.Entities;
using Products.Domain.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Domain.Abstractions.Repositories
{
    public interface ICategoryRepository : IRepositoryBase<Category>
    {
        Task<List<Category>> FindCategoriesAsync(CategoryFilter request);
        Task<bool> IsCategoryExists(Guid id);
    }
}
