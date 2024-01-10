using Products.Application.Common;
using Products.Application.DTOs;
using Products.Domain.Entities;
using Products.Domain.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Application.Abstractions
{
    public interface IProductService
    {
        Task<Result<List<ProductDto>>> GetProductsAsync(
            Guid categoryId, 
            ProductFilter request);
        Task<Result<ProductDto?>> GetProductAsync(
            Guid categoryId,
            Guid productId);
        Task<Result<ProductDto?>> CreateProductAsync(
            Guid categoryId,
            CreateProductDto productDto);
        Task<Result<ProductDto>> UpdateProductAsync(
            Guid categoryId,
            Guid productId,
            UpdateProductDto productDto);
        Task<Result<bool>> DeleteProductAsync(
            Guid categoryId,
            Guid productId);
    }
}
