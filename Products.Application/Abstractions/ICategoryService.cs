using Products.Application.Common;
using Products.Domain.Entities;
using Products.Domain.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Application.Abstractions
{
    public interface ICategoryService
    {
        Task<Result<List<Category>>> GetCategoriesAsync(CategoryFilter request);
    }
}
