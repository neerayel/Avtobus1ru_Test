using URLShortener.Data.Interfaces;
using URLShortener.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace URLShortener.Data
{
    public static class ServiceCollectionExtensions
    {
        private static IServiceCollection AddMariaDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContextPool<DataContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            return services;
        }


        public static IServiceCollection AddEfRepository(this IServiceCollection services, string connectionString)
        {
            services.AddMariaDbContext(connectionString);

            services.AddScoped<ILinkRepository, LinkRepository>();

            return services;
        }
    }
}
