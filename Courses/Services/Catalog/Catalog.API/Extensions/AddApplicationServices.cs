using Catalog.API.Data;
using Catalog.API.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Catalog.API.Extensions
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,IConfiguration config)
        {
            services.AddDbContext<CatalogContext>(option =>
            {
                option.UseNpgsql(config.GetConnectionString("DefaultString"));
            });
            services.AddAutoMapper(typeof(MappingProfiles).Assembly);
            services.AddScoped<IProductRepository, ProductRepository>();
            return services;
        }
    }
}
