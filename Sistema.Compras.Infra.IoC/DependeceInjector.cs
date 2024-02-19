using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Sistema.Compras.Infra.Data;

namespace Sistema.Compras.Infra.IoC
{
    public static class DependeceInjector
    {
        public static void AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 36));
            services.AddDbContext<AppDbContext>(
            dbContextOptions => dbContextOptions
                .UseMySql(configuration.GetConnectionString("compras_db"), serverVersion)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors()
        );
        }
    }
}
