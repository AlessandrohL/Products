using Products.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Domain.Entities
{
    public sealed class Category : BaseEntity
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public ICollection<Product>? Products { get; set; }

        public Category(Guid id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}
