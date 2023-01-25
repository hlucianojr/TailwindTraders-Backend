using Microsoft.Extensions.DependencyInjection;
using Tailwind.Traders.Profile.Api2.Helpers;
using Tailwind.Traders.Profile.Api2.Infrastructure;

namespace Tailwind.Traders.Profile.Api2.Extensions
{
    public static class ModulesExtensions
    {
        public static IServiceCollection AddModulesProfile(this IServiceCollection service)
        {
            service.AddScoped<CsvReaderHelper>(); 
            return service;
        }
    }
}
