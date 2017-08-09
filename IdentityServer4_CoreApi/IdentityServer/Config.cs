using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityServer
{
    public class Config
    {
        public static IEnumerable<ApiResource> GetApis()
        {
            return new List<ApiResource>
            {
                new ApiResource("First Resource Api", "First Resource .Net Core Api")
                {
                    ApiSecrets = { new Secret("fc0c80051ef5337d158433c4d1de088269093236".Sha256()) }
                }
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "cmd client",
                    ClientSecrets = { new Secret("cmd client secret".Sha256()) },

                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowedScopes = { "First Resource Api" },

                    AccessTokenType = AccessTokenType.Jwt
                }
            };
        }
    }
}