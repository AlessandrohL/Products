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

            if (result.IsError)
            {
                return result.Error!.Type switch
                {
                    ErrorType.NotFound => NotFound(result.Error!),
                    _ => BadRequest("An unexpected error occurred.")
                };
            }

            return Ok(result.Value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(
            Guid categoryId,
            [FromBody] CreateProductDto productDto)
        {
            var result = await _productService.CreateProductAsync(categoryId, productDto);

            if (result.IsError)
            {
                return result.Error!.Type switch
                {
                    ErrorType.NotFound => NotFound(result.Error!),
                    _ => BadRequest("An unexpected error occurred.")
                };
            }

            return CreatedAtRoute(
                nameof(GetProduct), 
                new { categoryId, id = result.Value!.Id },
                result.Value);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpdateProduct(
            Guid categoryId,
            Guid id,
            [FromBody] UpdateProductDto productDto)
        {
            var result = await _productService.UpdateProductAsync(categoryId, id, productDto);

            if (result.IsError)
            {
                return result.Error!.Type switch
                {
                    ErrorType.NotFound => NotFound(result.Error!),
                    _ => BadRequest("And unexpected error ocurred.")
                };
            }

            return Ok(result.Value);
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteProduct(
            Guid categoryId,
            Guid id)
        {
            var result = await _productService.DeleteProductAsync(categoryId, id);

            if (result.IsError)
            {
                return result.Error!.Type switch
                {
                    ErrorType.NotFound => NotFound(result.Error!),
                    _ => BadRequest("And unexpected error ocurred.")
                };
            }

            return NoContent();
        }
    }
}
