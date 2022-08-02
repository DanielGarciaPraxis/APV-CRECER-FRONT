using CanalesElectronicos.Infrastructure;
using CanalesElectronicos.Infrastructures.Common;
using CanalesElectronicosAPV.Core.Interfaces;
using CanalesElectronicosAPV.Core.UseCases;
using CanalesElectronicosAPV.Core.UseCases.Interfaces;

namespace CanalesElectronicosAPV
{
    public static class ServiceCollectionAll
    {
        public static IServiceCollection ServiceCollection(this IServiceCollection services)
        {
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IRestRepository, RestRepository>();
            services.AddScoped<IClienteUseCase, ClienteUseCase>();

            return services;
        }
    }
}
