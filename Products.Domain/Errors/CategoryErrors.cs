using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Domain.Errors
{
    public static class CategoryErrors
    {
        public static Error NotFound(Guid id) => new(
            ErrorType.NotFound, $"The Category with Id '{id}' was not found");

    }
}
