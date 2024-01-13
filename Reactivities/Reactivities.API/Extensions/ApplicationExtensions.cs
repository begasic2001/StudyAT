﻿using FluentValidation;
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
                //var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

                //string connStr;

                //    // Depending on if in development or production, use either FlyIO
                //    // connection string, or development connection string from env var.
                //    if (env == "Development")
                //    {
                //        // Use connection string from file.
                //        connStr = configuration.GetConnectionString("DefaultString");
                //    }
                //    else
                //    {
                //        // Use connection string provided at runtime by FlyIO.
                //        var connUrl = Environment.GetEnvironmentVariable("DATABASE_URL");

                //        // Parse connection URL to connection string for Npgsql
                //        connUrl = connUrl.Replace("postgres://", string.Empty);
                //        var pgUserPass = connUrl.Split("@")[0];
                //        var pgHostPortDb = connUrl.Split("@")[1];
                //        var pgHostPort = pgHostPortDb.Split("/")[0];
                //        var pgDb = pgHostPortDb.Split("/")[1];
                //        var pgUser = pgUserPass.Split(":")[0];
                //        var pgPass = pgUserPass.Split(":")[1];
                //        var pgHost = pgHostPort.Split(":")[0];
                //        var pgPort = pgHostPort.Split(":")[1];
                //        var updatedHost = pgHost.Replace("flycast", "internal");

                //        connStr = $"Server={updatedHost};Port={pgPort};User Id={pgUser};Password={pgPass};Database={pgDb};";
                //    }

                // Whether the connection string came from the local development configuration file
                // or from the environment variable from FlyIO, use it to set up your DbContext.
                //option.UseNpgsql(connStr);
                    //option.UseNpgsql(configuration.GetConnectionString("DefaultString"));
                    option.UseSqlServer(configuration.GetConnectionString("DefaultString"));
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
                                   .WithExposedHeaders("WWW-Authenticate", "Pagination")
                                   .WithOrigins("https://localhost:3000");

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
