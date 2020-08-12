using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityServer4Demo.TokenServer.Data
{
    internal static class ClientManager
    {
        public static IEnumerable<Client> Clients =>
            new List<Client>
            {
                    new Client
                    {
                        // Fuji's comments
                        // Client = app.   GTM example: Employee Profile Angular SPA
                         ClientName = "Client Application1",
                        // Fuji's comments
                        // ClientId is like AppId in Azure > App Registraion 
                         ClientId = "t8agr5xKt4$3",
                         AllowedGrantTypes = GrantTypes.ClientCredentials,
                        // Fuji's comments
                        // ClientSecrets is like Azure Service Principle
                         ClientSecrets = { new Secret("eb300de4-add9-42f4-a3ac-abd3c60f1919".Sha256()) },
                         AllowedScopes = new List<string> { "app.api.whatever.read", "app.api.whatever.write" }
                    },
                    new Client
                    {
                        // Fuji's comments
                        // Another app.  GTM example: DS Transfer Form Angular SPA
                         ClientName = "Client Application2",
                         ClientId = "3X=nNv?Sgu$S",
                         AllowedGrantTypes = GrantTypes.ClientCredentials,
                         ClientSecrets = { new Secret("1554db43-3015-47a8-a748-55bd76b6af48".Sha256()) },
                         AllowedScopes = { "app.api.weather" }
                    }
            };
    }
}
