using Products.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Domain.Entities
{
    public sealed class Product : BaseEntity
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public Category? Category { get; set; }
        public Guid CategoryId { get; set; }
    }
}
