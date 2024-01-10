using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Domain.Errors
{
    public static class ProductErrorsValidation
    {
        public const string NameRequired = "El nombre del producto es requerido.";
        public const string DescriptionRequired = "La descripción del producto es requerido.";
        public const string StockRequired = "El stock del producto es requerido.";
        public const string PriceRequired = "El precio del producto es requerido.";
        public const string InvalidPrice = "El precio debe ser mayor que cero.";
        public const string InvalidStock = "La cantidad en stock debe ser mayor que cero.";
    }
}
