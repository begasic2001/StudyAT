using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Reactivities.Application.Activities;
using Reactivities.Application.Core;
using Reactivities.Application.Interfaces;
using Reactivities.Infrastructure.Photos;
using Reactivities.Infrastructure.Security;
using Reactivities.Persistence;

namespace Reactivities.API.Extensions
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            {
                services.AddEndpointsApiExplorer();
                services.AddSwaggerGen();
                services.AddDbContext<ReactivitiesContext>(option =>
                {
                    option.UseNpgsql(configuration.GetConnectionString("DefaultString"));
                    //option.UseSqlServer(configuration.GetConnectionString("DefaultString"));
                });
                services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(List.Handler).Assembly));
                services.AddCors(opt =>
                {
                    opt.AddPolicy("CorsPolicy", policy =>
                    {
                        policy
                                   .AllowAnyMethod()
                                   .AllowAnyHeader()
                                   .AllowCredentials()
                                   .WithOrigins("http://localhost:5173");

                    });
                });
                services.AddAutoMapper(typeof(MappingProfiles).Assembly);
                services.AddFluentValidationAutoValidation();
                services.AddValidatorsFromAssemblyContaining<Create>();
                services.AddHttpContextAccessor();
                services.AddScoped<IUserAccessor, UserAccessor>();
                services.AddScoped<IPhotoAccessor, PhotoAccessor>();
                services.Configure<CloudinarySetting>(configuration.GetSection("Cloudinary"));
                services.AddSignalR();
                return services;
            }
        }
    }
}
