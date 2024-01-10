using Products.Domain.Errors;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Application.DTOs
{
    public record CreateProductDto
    {
        [Required(ErrorMessage = ProductErrorsValidation.NameRequired)]
        public string? Name { get; init; }

        [Required(ErrorMessage = ProductErrorsValidation.DescriptionRequired)]
        public string? Description { get; init; }

        [Required(ErrorMessage = ProductErrorsValidation.PriceRequired)]
        [Range(0.01, double.MaxValue, ErrorMessage = ProductErrorsValidation.InvalidPrice)]
        public decimal Price { get; init; }

        [Required(ErrorMessage = ProductErrorsValidation.StockRequired)]
        [Range(0, int.MaxValue, ErrorMessage = ProductErrorsValidation.InvalidStock)]
        public int StockQuantity { get; init; }
    }
}
