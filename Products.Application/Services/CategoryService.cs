using Products.Application.Abstractions;
using Products.Application.Common;
using Products.Domain.Abstractions;
using Products.Domain.Entities;
using Products.Domain.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Application.Services
{
    public sealed class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<List<Category>>> GetCategoriesAsync(CategoryFilter request)
        {
            return await _unitOfWork.Category.FindCategoriesAsync(request);
        }
    }
}
