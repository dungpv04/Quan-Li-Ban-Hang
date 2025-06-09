using Database.IRepositories;
using Database.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Services.IServices;
using Services.Services;

public static class ServiceDependency
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IProductTypeService, ProductTypeService>();
        services.AddScoped<IBrandService, BrandService>();
        services.AddScoped<ISupplierService, SupplierService>();
        services.AddScoped<IEmployeeService, EmployeeService>();
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IRevenueReportService, RevenueReportService>();
        return services;
    }

    public static void Main()
    {

    }
}
