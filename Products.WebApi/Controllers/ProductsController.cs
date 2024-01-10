using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Products.Application.Abstractions;
using Products.Application.DTOs;
using Products.Domain.Errors;
using Products.Domain.Filters;
using System.Net;

namespace Products.WebApi.Controllers
{
    [Route("api/categories/{categoryId:guid}/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts(
            Guid categoryId,
            [FromQuery] ProductFilter request)
        {
            var result = await _productService.GetProductsAsync(categoryId, request);

            return result.Match<IActionResult>(Ok, BadRequest);
        }

        [HttpGet("{id:guid}", Name = nameof(GetProduct))]
        public async Task<IActionResult> GetProduct(
            Guid categoryId,
            Guid id)
        {
            var result = await _productService.GetProductAsync(categoryId, id);

            return result.Match<IActionResult>(Ok, NotFound);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(
            Guid categoryId,
            [FromBody] CreateProductDto productDto)
        {
            var result = await _productService.CreateProductAsync(categoryId, productDto);

            return result.Match<IActionResult>(
                createdProduct => CreatedAtRoute(
                    nameof(GetProduct), 
                    new { categoryId, id = createdProduct!.Id },
                    createdProduct),
                NotFound);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpdateProduct(
            Guid categoryId,
            Guid id,
            [FromBody] UpdateProductDto productDto)
        {
            var result = await _productService.UpdateProductAsync(categoryId, id, productDto);

            return result.Match<IActionResult>(Ok, NotFound);
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteProduct(
            Guid categoryId,
            Guid id)
        {
            var result = await _productService.DeleteProductAsync(categoryId, id);

            return result.Match<IActionResult>((s) => NoContent(), NotFound);
        }
    }
}
