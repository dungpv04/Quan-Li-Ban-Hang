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
        return services;
    }

    public static void Main()
    {

    }
}
