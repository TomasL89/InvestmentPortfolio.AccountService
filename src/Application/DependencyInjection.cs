using System.Reflection;
using Application.Commands;
using Application.Queries;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        /*services.AddMediatR(typeof(CreateAccount));
        services.AddMediatR(typeof(UpdateAccount));
        services.AddMediatR(typeof(GetAccountById));
        services.AddMediatR(typeof(DeleteAccount));*/
        services.AddMediatR(cfg=>cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
        
        return services;
    }
}