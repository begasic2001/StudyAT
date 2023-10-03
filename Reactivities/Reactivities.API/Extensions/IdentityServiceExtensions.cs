using FluentValidation.AspNetCore;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Reactivities.Application.Activities;
using Reactivities.Application.Core;
using Reactivities.Persistence;
using Reactivities.Domain;
using Reactivities.API.Services;

namespace Reactivities.API.Extensions
{
    public static class IdentityServiceExtensions
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration configuration)
        {
            {
                services.AddIdentityCore<AppUser>(opt =>
                {
                    opt.Password.RequireNonAlphanumeric = false;
                }).AddEntityFrameworkStores<ReactivitiesContext>();
                services.AddAuthentication();
                services.AddScoped<TokenService>();
                return services;
            }
        }
    }
}
