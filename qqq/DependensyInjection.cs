using Cars.BLL.Contracts;
using Cars.BLL.Internals;
using Microsoft.Extensions.DependencyInjection;

namespace DependensyInjection
{
    public static class DependensyInjection
    {
        public static IServiceCollection AddBusinessLayer(this IServiceCollection services)
        {
            return services.AddScoped<ICarsServices, CarsService>().AddScoped<IAccountsServices, AccountsService>();
        }
    }
}
