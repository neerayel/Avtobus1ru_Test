using Avtobus1ru_Test.Data;
using Avtobus1ru_Test.MidLogic.Interfaces;
using Avtobus1ru_Test.MidLogic.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Avtobus1ru_Test.MidLogic
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
