using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Products.Domain.Abstractions;
using Products.Domain.Abstractions.Repositories;
using Products.Infrastructure.Persistence.Contexts;
using Products.Infrastructure.Repositories;
using Products.Infrastructure.UnitOfWorks;

namespace Products.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure
            (this IServiceCollection services, IConfiguration configuration)
        {
            string connectionStr = configuration.GetConnectionString("DevConnection")
                                   ?? throw new ArgumentNullException("Connection string is null.");

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionStr));

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
