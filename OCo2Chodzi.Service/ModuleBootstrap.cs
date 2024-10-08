using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OCo2Chodzi.Service.Adapters;
using OCo2Chodzi.Service.Infrastructure;
using OCo2Chodzi.Service.Ports;

namespace OCo2Chodzi.Service;

public static class ModuleBootstrap
{
    public static IServiceCollection RegisterServiceModule(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options => 
        {
            options.UseSqlServer(configuration.GetRequiredSection("Database")["ConnectionString"], builder => 
            {
                builder.MigrationsAssembly("OCo2Chodzi.Endpoint")
                    .UseNetTopologySuite();
                
            });
        });

        services.AddScoped<IDiscoveryProvider, DiscoveryProvider>();
        services.AddScoped<IAbsorbionCalculator, AbsorbionCalculator>();

        return services;
    }
}