using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Reactivities.Persistence
{
    public static class DependenceInjection
    {
        public static IServiceCollection AddServiceCollection(this IServiceCollection services, IConfiguration configuration)
        {
            
            services.AddDbContext<ReactivitiesContext>(option =>
            {
                option.UseSqlServer(configuration.GetConnectionString("DefaultString"));
            });
            return services;
        }
    }
}
