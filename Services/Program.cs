using Microsoft.Extensions.DependencyInjection;
using Services.IServices;
using Services.Services;

public static class ServiceDependency
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IProductTypeService, ProductTypeService>();
        return services;
    }

    public static void Main()
    {

    }
}
