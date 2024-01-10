using Microsoft.Extensions.DependencyInjection;
using Products.Application.Abstractions;
using Products.Application.Services;
using System.Reflection;

namespace Products.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();

            return services;
        }
    }
}
