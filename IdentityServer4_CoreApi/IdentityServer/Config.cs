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
                new ApiResource("First_Resource_API", "First Resource .Net Core Api")
                {
                    ApiSecrets = { new Secret("secret".Sha256()) }
                }
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "cmd_client",
                    ClientSecrets = { new Secret("secret".Sha256()) },

                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowedScopes = { "First_Resource_API" }

                    //AccessTokenType = AccessTokenType.Jwt
                },
                new Client
                {
                    ClientId = "js_oauth",
                    ClientSecrets = { new Secret("secret".Sha256()) },

                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowedScopes = { "First_Resource_API" }

                    //AccessTokenType = AccessTokenType.Jwt
                }
            };
        }
    }
}