using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MvcClient.Web.Infrastructure
{
    public static class DIConfiguration
    {
        public static void ConfigureDependencies(IServiceCollection services, IConfigurationRoot config)
        {
            BLL.Infrastructure.DIConfiguration.ConfigureDependencies(services, config);
        }
    }
}
