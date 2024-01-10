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
    public sealed class CategoryRepository
        : RepositoryBase<Category>, ICategoryRepository
    {

        public CategoryRepository(ApplicationDbContext context)
            : base(context)
        { }

        public async Task<List<Category>> FindCategoriesAsync(CategoryFilter request)
        {
            return await FindAll(trackChanges: false)
                 .OrderBy(c => c.Name)
                 .Paginate(request.Page, request.PageSize)
                 .ToListAsync();
        }

        public async Task<bool> IsCategoryExists(Guid id)
        {
            return await FindByCondition(c => c.Id == id, trackChanges: false)
                .AnyAsync();
        }
    }
}
