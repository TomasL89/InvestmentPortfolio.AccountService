using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("AccountContext");
        services.AddDbContext<AccountDbContext>(options =>
            options.UseSqlServer(connectionString));
        // https://github.com/jasontaylordev/CleanArchitecture/blob/main/src/Infrastructure/DependencyInjection.cs
        return services;
    }
}