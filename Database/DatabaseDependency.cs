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
        services.AddScoped<IBrandRepository, BrandRepository>();
        services.AddScoped<ISupplierRepository, SupplierRepository>();
        services.AddScoped<IProductTypeRepository, ProductTypeRepository>(); 
        services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();

        services.AddDbContext<AppDbContext>();
        return services;
    }
}