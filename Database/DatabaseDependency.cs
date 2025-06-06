using Database.IRepositories;
using Database.Models;
using Database.Repositories;
using Microsoft.Extensions.DependencyInjection;

public static class DatabaseDependency
{
    public static IServiceCollection AddDatabase(this IServiceCollection services)
    {
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        services.AddScoped<IProductTypeRepository, ProductTypeRepository>(); // Fixed syntax
        services.AddScoped<IRevenueReportRepository, RevenueReportRepository>();
        services.AddDbContext<AppDbContext>();
        return services;
    }
}