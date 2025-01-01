using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NoobGGApp.Application.Common.Interfaces;
using NoobGGApp.Infrastructure.Persistence.EntityFramework.Contexts;
using NoobGGApp.Infrastructure.Services;
using StackExchange.Redis;

namespace NoobGGApp.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsHistoryTable("__ef_migrations_history"))
                .UseSnakeCaseNamingConvention());
        
        services
            .AddScoped<IApplicationDbContext, ApplicationDbContext>();
        services.AddStackExchangeRedisCache(options =>
        {
            options.Configuration = configuration.GetConnectionString("Redis");
            options.InstanceName = "NoobGGApp_";
        });
        services.AddSingleton<ICacheKeyFactory, CacheKeyFactory>();
        services.AddScoped<ICacheInvalidator, CacheInvalidator>();
        
        // Register Redis connection for advanced operations
        services.AddSingleton<IConnectionMultiplexer>(sp =>
            ConnectionMultiplexer.Connect(configuration.GetConnectionString("Redis")));
        
        return services;
    }
}