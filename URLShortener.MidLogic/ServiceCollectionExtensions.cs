using URLShortener.Data;
using URLShortener.MidLogic.Interfaces;
using URLShortener.MidLogic.Services;
using Microsoft.Extensions.DependencyInjection;

namespace URLShortener.MidLogic
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBusinessLogicService(this IServiceCollection services, string connectionString)
        {
            services.AddEfRepository(connectionString);

            services.AddScoped<ILinkService, LinkService>();

            return services;
        }
    }
}
