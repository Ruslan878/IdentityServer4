using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MvcClient.BLL.Infrastructure
{
    public static class DIConfiguration
    {
        public static void ConfigureDependencies(IServiceCollection services, IConfigurationRoot config)
        {
            DAL.Infrastructure.DIConfiguration.ConfigureDependencies(services, config);
        }
    }
}
