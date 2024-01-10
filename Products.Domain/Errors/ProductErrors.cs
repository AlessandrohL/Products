using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Domain.Errors
{
    public static class ProductErrors
    {
        public static Error NotFound(Guid id) => new(
            ErrorType.NotFound, $"The Product with Id '{id}' was not found");
    }
}
