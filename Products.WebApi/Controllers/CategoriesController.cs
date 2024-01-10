using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Products.Application.Abstractions;
using Products.Domain.Filters;

namespace Products.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategories(
            [FromQuery] CategoryFilter request)
        {
            var result = await _categoryService.GetCategoriesAsync(request);

            return result.Match<IActionResult>(Ok, NotFound);
        }


    }
}
