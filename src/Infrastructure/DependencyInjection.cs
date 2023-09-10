using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var server = configuration["DBServer"] ?? "sql-server";
        var port = configuration["DBPort"] ?? "1433";
        var user = configuration["DBUser"] ?? "SA";
        var password = configuration["DBPassword"] ?? "Password123";
        var database = configuration["Database"] ?? "Account";
        services.AddDbContext<AccountDbContext>(options =>
            options.UseSqlServer($"Server={server},{port};Database={database};User ID={user};Password={password};MultipleActiveResultSets=true;Encrypt=False"));
        return services;
    }
}