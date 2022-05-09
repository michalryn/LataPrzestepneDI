using LataPrzestepneDI.Interfaces;
using LataPrzestepneDI.Services;
using LataPrzestepneDI.Repositories;

namespace LataPrzestepneDI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddProjectService(this IServiceCollection services)
        {
            services.AddTransient<IPersonRepository, PersonRepository>();
            services.AddTransient<IPersonService, PersonService>();

            return services;
        }
    }
}
