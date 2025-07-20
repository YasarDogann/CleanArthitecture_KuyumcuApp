using CleanArthitecture_KuyumcuApp.Application.Repositories;
using CleanArthitecture_KuyumcuApp.Persistence.Context;
using CleanArthitecture_KuyumcuApp.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace CleanArthitecture_KuyumcuApp.Persistence.ServiceRegistration;
public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("PostgreSQL");

        services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(connectionString));

        services.AddScoped<ICategoryWriteRepository, CategoryWriteRepository>();
        services.AddScoped<ICategoryReadRepository, CategoryReadRepository>();

        return services;
    }
}