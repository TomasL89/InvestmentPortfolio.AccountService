using System.Reflection;

namespace Api;

public static class ExtensionsServiceCollection
{
    /*public static IServiceCollection AddMediatorHandlers(this IServiceCollection services)
    {
          services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssemblies(
                    typeof(Infrastructure.Handlers.GetAccountByIdQueryHandler).GetTypeInfo().Assembly);
                cfg.RegisterServicesFromAssemblies(
                    typeof(Infrastructure.Handlers.CreateAccountCommandHandler).GetTypeInfo().Assembly);
                cfg.RegisterServicesFromAssemblies(
                    typeof(Infrastructure.Handlers.UpdateAccountCommandHandler).GetTypeInfo().Assembly);
                cfg.RegisterServicesFromAssemblies(
                    typeof(Infrastructure.Handlers.DeleteAccountCommandHandler).GetTypeInfo().Assembly);
            });
        return services;
    }*/
}