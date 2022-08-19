using Mapster.Infrastructure.Contracts;
using Mapster.Infrastructure.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapster.Infrastructure
{
    public static class ServiceConfiguration 
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDatabaseContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), provider => provider.MigrationsAssembly("Mapster.API"));
            });

            services.AddScoped<IApplicationDatabaseContext>(provider => provider.GetRequiredService<ApplicationDatabaseContext>());

            return services; 
            
        }
    }
}
