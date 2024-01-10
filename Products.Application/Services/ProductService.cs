using AutoMapper;
using Products.Application.Abstractions;
using Products.Application.Common;
using Products.Application.DTOs;
using Products.Domain.Abstractions;
using Products.Domain.Entities;
using Products.Domain.Errors;
using Products.Domain.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Application.Services
{
    public sealed class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<List<ProductDto>>> GetProductsAsync(
            Guid categoryId, 
            ProductFilter request)
        {
            var categoryExists = await _unitOfWork.Category
                .IsCategoryExists(categoryId);

            if (!categoryExists)
            {
                return CategoryErrors.NotFound(categoryId);
            }

            var productsDb = await _unitOfWork.Product
                .FindProductsAsync(categoryId, request);

            var productsDto = _mapper.Map<List<ProductDto>>(productsDb);

            return productsDto;
        }

        public async Task<Result<ProductDto?>> GetProductAsync(Guid categoryId, Guid productId)
        {
            var categoryExists = await _unitOfWork.Category
                .IsCategoryExists(categoryId);

            if (!categoryExists)
            {
                return CategoryErrors.NotFound(categoryId);
            }

            var product = await _unitOfWork.Product
                .FindProductByIdAsync(categoryId, productId, false);

            if (product is null)
            {
                return ProductErrors.NotFound(productId);
            }

            return _mapper.Map<ProductDto>(product);
        }

        public async Task<Result<ProductDto?>> CreateProductAsync(
            Guid categoryId,
            CreateProductDto productDto)
        {
            var categoryExists = await _unitOfWork.Category
                .IsCategoryExists(categoryId);

            if (!categoryExists)
            {
                return CategoryErrors.NotFound(categoryId);
            }

            var product = _mapper.Map<Product>(productDto);
            product.CategoryId = categoryId;

            _unitOfWork.Product.Create(product);

            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<ProductDto>(product);
        }

        public async Task<Result<ProductDto>> UpdateProductAsync(
            Guid categoryId,
            Guid productId,
            UpdateProductDto productDto)
        {
            var categoryExists = await _unitOfWork.Category
                .IsCategoryExists(categoryId);

            if (!categoryExists)
            {
                return CategoryErrors.NotFound(categoryId);
            }

            var productDb = await _unitOfWork.Product
                .FindProductByIdAsync(categoryId, productId, trackChanges: true);

            if (productDb is null)
            {
                return ProductErrors.NotFound(productId);
            }

            productDb = _mapper.Map(productDto, productDb);
            productDb.SetModified();

            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<ProductDto>(productDb);
        }

        public async Task<Result<bool>> DeleteProductAsync(Guid categoryId, Guid productId)
        {
            var categoryExists = await _unitOfWork.Category
                .IsCategoryExists(categoryId);

            if (!categoryExists)
            {
                return CategoryErrors.NotFound(categoryId);
            }

            var productExist = await _unitOfWork.Product
                .IsProductExists(categoryId, productId);

            if (!productExist)
            {
                return ProductErrors.NotFound(productId);
            }

            _unitOfWork.Product.Delete(new Product { Id = productId });

            await _unitOfWork.SaveChangesAsync();

            return true;
        }

    }
}
