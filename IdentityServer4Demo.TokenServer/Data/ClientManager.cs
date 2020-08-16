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
                        // Client = app. 
                         ClientName = "Client Application1",
                         ClientId = "t8agr5xKt4$3",
                         AllowedGrantTypes = GrantTypes.ClientCredentials,
                         ClientSecrets = { new Secret("eb300de4-add9-42f4-a3ac-abd3c60f1919".Sha256()) },
                         AllowedScopes = new List<string> { "app.api.whatever.read", "app.api.whatever.write" }
                    },
                    new Client
                    {
                        // Fuji's comments
                        // Another app.
                         ClientName = "Weather App",
                         ClientId = "3X=nNv?Sgu$S",
                         AllowedGrantTypes = GrantTypes.ClientCredentials,
                         ClientSecrets = { new Secret("1554db43-3015-47a8-a748-55bd76b6af48".Sha256()) },
                         AllowedScopes = { "app.api.weather" }
                    },
                    new Client
                    {
                        // Fuji's comments
                        // Client to work with the EmployeeProfile 
                         ClientName = "Employee Profile App",
                         // The ClientID is referenced in the EmployeeProfile > appsettings.json > Self > Id field
                         ClientId = "4X=nNv?Sgu$T",
                         AllowedGrantTypes = GrantTypes.ClientCredentials,
                         // The ClientSecrets is referenced in the EmployeeProfile > appsettings.json > Self > Secret field
                         ClientSecrets = { new Secret("0a2e472b-f263-43fd-8372-3b13f5acf222".Sha256()) },
                         AllowedScopes = new List<string> { "app.api.employeeprofile.read", "app.api.employeeprofile.write" }

                    }
            };
    }
}
