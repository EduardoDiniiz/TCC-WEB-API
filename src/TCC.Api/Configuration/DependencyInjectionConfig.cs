using Microsoft.Extensions.DependencyInjection;
using TCC.Business.Intefaces;
using TCC.Business.Notificacoes;
using TCC.Data.Context;

namespace TCC.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<INotificador, Notificador>();
            return services;
        }
    }
}
