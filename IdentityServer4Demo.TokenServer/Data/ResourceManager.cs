using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityServer4Demo.TokenServer.Data
{
    internal static class ResourceManager
    {
        public static IEnumerable<ApiResource> Apis =>
            new List<ApiResource>
            {

                // Fuji's comments
                // A place holder ApiResource that can be used for your app
                new ApiResource {
                    Name = "app.api.whatever",
                    DisplayName = "Whatever Apis",
                    ApiSecrets = { new Secret("a75a559d-1dab-4c65-9bc0-f8e590cb388d".Sha256()) },
                    Scopes = new List<Scope> {
                        new Scope("app.api.whatever.read"),
                        new Scope("app.api.whatever.write"),
                        new Scope("app.api.whatever.full")
                    }
                },
                // Fuji's comments
                // Register Weather ApiResource in the solution
                new ApiResource {
                    Name = "app.api.weather",
                    DisplayName = "Weather Apis",
                    ApiSecrets = { new Secret("a75a559d-1dab-4c65-9bc0-f8e590cb389e".Sha256()) },
                    Scopes = new List<Scope> {
                        new Scope("app.api.weather"),
                    }
                },
                // Fuji's comments
                // Register EmployeeProfile ApiResource generated using the ApiBoilerPlate tempate
                new ApiResource {
                    Name = "app.api.employeeprofile",
                    DisplayName = "EmployeeProfile Apis",
                    ApiSecrets = { new Secret("0a2e472b-f263-43fd-8372-3b13f5acf222".Sha256()) },
                    Scopes = new List<Scope> {
                        new Scope("app.api.employeeprofile.read"),
                    }
                },
            };
    }
}
