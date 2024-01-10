using Products.Domain.Errors;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Application.DTOs
{
    public record UpdateProductDto
    {
        [Required(ErrorMessage = ProductErrors.NameRequired)]
        public string? Name { get; init; }

        [Required(ErrorMessage = ProductErrors.DescriptionRequired)]
        public string? Description { get; init; }

        [Required(ErrorMessage = ProductErrors.PriceRequired)]
        [Range(0.01, double.MaxValue, ErrorMessage = ProductErrors.InvalidPrice)]
        public decimal Price { get; init; }

        [Required(ErrorMessage = ProductErrors.StockRequired)]
        [Range(0, int.MaxValue, ErrorMessage = ProductErrors.InvalidStock)]
        public int StockQuantity { get; init; }
    }
}
