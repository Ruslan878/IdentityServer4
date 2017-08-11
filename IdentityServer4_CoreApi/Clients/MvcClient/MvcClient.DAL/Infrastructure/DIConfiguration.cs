using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MvcClient.DAL.DbContext;
using MvcClient.Domain.Models;

namespace MvcClient.DAL.Infrastructure
{
    public static class DIConfiguration
    {
        public static void ConfigureDependencies(IServiceCollection services, IConfigurationRoot config)
        {
            services.AddDbContext<IdentityContextDB>(options =>
                options.UseSqlServer(config.GetConnectionString("LocalConnectionString")));

            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<IdentityContextDB>();
        }
    }
}
