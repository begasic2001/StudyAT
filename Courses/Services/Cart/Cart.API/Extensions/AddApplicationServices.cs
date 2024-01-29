
using Cart.API.Repositories;
using Microsoft.Extensions.Configuration;

namespace Cart.API.Extensions
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,IConfiguration config)
        {
            services.AddStackExchangeRedisCache(opt =>
            {
                opt.Configuration = config.GetValue<string>("CacheSettings:ConnectionString");
            });
            services.AddScoped<ICartRepository, CartRepository>();
            return services;
        }
    }
}
