using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Application.DTOs
{
    public record ProductDto
    {
        public Guid Id { get; init; }
        public string? Name { get; init; }
        public string? Description { get; init; }
        public decimal Price { get; init; }
        public int StockQuantity { get; init; }
        public Guid CategoryId { get; init; }
    }
}
