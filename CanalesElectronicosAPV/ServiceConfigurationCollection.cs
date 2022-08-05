
﻿//using KeycloakTokenManager.Common;
//using NetCore.KeycloakTokenManager;


namespace CanalesElectronicosAPV
{
    public static class ServiceConfigurationCollection
    {
        public static IServiceCollection ServiceConfiguration(this IServiceCollection services, IConfiguration configuration)
        {

            //var Ke = new KeycloakUrlOptions();

            //IConfiguration configuration = configuration;
            //configuration.GetSection("KeyCloakConfigs").Bind(Ke);

            //var gg = configuration.GetSection("KeyCloakConfigs") as KeycloakConfigs;
            //var miappsettings = configuration["KeyCloakConfigs:KeycloakUrl"];
            //KeycloakConfigs keycloakConfigs = new()
            //{
            //    ClientId = configuration["KeyCloakConfigs:ClientId"],
            //    ClientSecret = configuration["KeyCloakConfigs:ClientSecret"],
            //    KeycloakUrl = configuration["KeyCloakConfigs:KeycloakUrl"],
            //    Realm = configuration["KeyCloakConfigs:Realm"]
            //};
            var gg = "";
            //configuration.Bind("KeyCloakConfigs", KeyCloakConfigs);

            //services.AddTokenManager(Ke);

            //services.AddTokenManager(new KeycloakUrlOptions
            //{
            //    ClientId = configuration["KeyCloakConfigs:ClientId"],
            //    ClientSecret = configuration["KeyCloakConfigs:ClientSecret"],
            //    KeycloakUrl = configuration["KeyCloakConfigs:KeycloakUrl"],
            //    Realm = configuration["KeyCloakConfigs:Realm"]
            //});

            return services;
        }
    }
}
