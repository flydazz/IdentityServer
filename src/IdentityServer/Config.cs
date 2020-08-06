using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer
{
    public class Config
    {

        ///// <summary>
        ///// 4.0以下版本用ApiResource
        ///// </summary>
        ///// <returns></returns>
        //public static IEnumerable<ApiResource> GetApiResources()
        //{
        //    return new List<ApiResource>()
        //    {
        //        new ApiResource("Api1","my api1")
        //    };

        //}

        /// <summary>
        /// V4以后使用ApiScope
        /// </summary>
        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new List<ApiScope>
            {
                new ApiScope("api1", "my api1"),
            };
        }
        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>()
            {
                new Client()
                {
                     ClientId="client",
                     ClientSecrets=
                     {
                         new Secret("secret".Sha256())
                     },
                     AllowedGrantTypes = GrantTypes.ClientCredentials,
                     AllowedScopes = new string[]{ "api1" }
                },
                 new Client()
                {
                     ClientId="client_pwd",
                     ClientSecrets=
                     {
                         new Secret("secret".Sha256())
                     },
                     AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,
                     AllowedScopes = new string[]{ "api1" }
                }
            };
        }

    }
}
