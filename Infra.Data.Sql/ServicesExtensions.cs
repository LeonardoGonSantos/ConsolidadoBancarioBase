using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Data
{
    public static class ServicesExtensions
    {
        public static void AddInfraDataServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SqlContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("SqlConnection"),
                                     providerOptions => providerOptions.EnableRetryOnFailure()));

            services.AddScoped<SqlContext>();
        }
    }
}
