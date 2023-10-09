using Reactivities.Persistence;
using Reactivities.Domain;
using Reactivities.API.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Reactivities.API.Dtos;
using Reactivities.Infrastructure.Security;
using Microsoft.AspNetCore.Authorization;

namespace Reactivities.API.Extensions
{
    public static class IdentityServiceExtensions
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration config)
        {
            {
                services.AddIdentityCore<AppUser>(opt =>
                {
                    opt.Password.RequireNonAlphanumeric = false;
                    opt.User.RequireUniqueEmail = true;
                }).AddEntityFrameworkStores<ReactivitiesContext>();

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["TokenKey"]));

                services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                    .AddJwtBearer(opt =>
                    {
                        opt.TokenValidationParameters = new TokenValidationParameters
                        {
                            ValidateIssuerSigningKey = true,
                            IssuerSigningKey = key,
                            ValidateIssuer = false,
                            ValidateAudience=false
                        };
                    }
                );
                services.AddAuthorization(opt =>
                {
                    opt.AddPolicy("IsActivityHost", policy =>
                    {
                        policy.Requirements.Add(new IsHostRequirement());
                    });
                });
                services.AddTransient<IAuthorizationHandler, IsHostRequirementHandler>();
                services.AddScoped<TokenService>();
                return services;
            }
        }
      
    }
}
