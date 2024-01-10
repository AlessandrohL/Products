using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Application.Common
{
    public record class Error
    {
        public string Type { get; init; } = string.Empty;
        public string Description { get; init; } = string.Empty;

        public Error(string type, string description)
        {
            Type = type;
            Description = description;
        }
    }
}
