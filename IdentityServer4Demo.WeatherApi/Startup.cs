using IdentityServer4.AccessTokenValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace IdentityServer4Demo.WeatherApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var stsServer = Configuration["StsServer"];

            services.AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme)
                    // Fuji's comments
                    // Code to validate JWT token.  
                    // The Authority is the Token Serive server URL
                    // The ApiName is defined in the ResourceManager

                    .AddIdentityServerAuthentication(options =>
                    {
                        options.Authority = stsServer;
                        options.ApiName = "app.api.weather";
                        options.ApiSecret = "a75a559d-1dab-4c65-9bc0-f8e590cb388d";
                    });

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

