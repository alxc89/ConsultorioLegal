using src.api.Application.Services.Clientes.Implementation;
using src.api.Application.Services.Clientes.Interfaces;
using src.api.Application.Services.Clientes;
using src.api.Infrastructure.Database.Repositories;

namespace ConsultorioLegal.Configuration
{
    public static class DependencyIngectionConfig
    {
        public static void AddDependecyInjectionConfiguration(this IServiceCollection services)
        {
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IClienteManager, ClienteManager>();
        }
    }
}
