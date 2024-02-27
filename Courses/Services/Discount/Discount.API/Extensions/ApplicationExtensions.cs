using Catalog.API.Data;
using Microsoft.EntityFrameworkCore;

namespace Discount.API.Extensions
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<DiscountContext>(option =>
            {
                option.UseNpgsql(config.GetConnectionString("DefaultString"));
            });
            //services.AddAutoMapper(typeof(MappingProfiles).Assembly);
            //services.AddScoped<IProductRepository, ProductRepository>();
            return services;
        }
    }
}
