using Cars.BLL.Internals;
using Cars.BLL.Contracts;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DependensyInjection
{
    public static class DependensyInjection
    {
        public static IServiceCollection AddBusinessLayer(this IServiceCollection services)
        {
            return services.AddScoped<ICarsServices, CarsService>();
           
        }
    }
}
