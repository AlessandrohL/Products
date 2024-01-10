using Products.Domain.Abstractions.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Domain.Abstractions
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        IProductRepository Product { get; }
        Task<int> SaveChangesAsync();
    }
}
