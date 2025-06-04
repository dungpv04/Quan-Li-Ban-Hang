using Microsoft.Extensions.DependencyInjection;
using Shared.Factory;
using Shared.IFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public static class SharedDependencies
    {
        public static IServiceCollection AddShared(this IServiceCollection services)
        {
            services.AddSingleton<IAbstractFactory, ViewModelAbstractFactory>();
            return services;
        }
    }
}
