using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using System;


namespace MvcClient.DAL.DbContext
{
    public class IdentityContextDBFactory : IDbContextFactory<IdentityContextDB>
    {
        public IdentityContextDB Create()
        {
            var environmentName =
                Environment.GetEnvironmentVariable(
                    "Hosting:Environment");

            var basePath = AppContext.BaseDirectory;

            return Create(basePath, environmentName);
        }

        public IdentityContextDB Create(DbContextFactoryOptions options)
        {
            return Create(
                options.ContentRootPath,
                options.EnvironmentName);
        }

        private IdentityContextDB Create(string basePath, string environmentName)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{environmentName}.json", true)
                .AddEnvironmentVariables();

            var config = builder.Build();

            var connstr = config.GetConnectionString("LocalConnectionString");

            if (String.IsNullOrWhiteSpace(connstr) == true)
            {
                throw new InvalidOperationException(
                    "Could not find a connection string named 'LocalConnectionString'.");
            }
            else
            {
                return Create(connstr);
            }
        }

        private IdentityContextDB Create(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentException(
                    $"{nameof(connectionString)} is null or empty.",
                    nameof(connectionString));

            var optionsBuilder =
                new DbContextOptionsBuilder<IdentityContextDB>();

            optionsBuilder.UseSqlServer(connectionString);

            return new IdentityContextDB(optionsBuilder.Options);
        }
    }

}
