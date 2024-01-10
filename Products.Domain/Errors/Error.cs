using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Domain.Errors
{
    public record class Error
    {
        public ErrorType Type { get; init; }
        public string Description { get; init; } = string.Empty;

        public Error(ErrorType type, string description)
        {
            Type = type;
            Description = description;
        }
    }
}
