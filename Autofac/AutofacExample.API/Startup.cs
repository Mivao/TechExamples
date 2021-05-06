using Autofac;
using AutofacExample.API.Interfaces;
using AutofacExample.API.Providers;
using AutofacExample.API.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace AutofacExample.API
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
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "AutofacExample.API", Version = "v1" });
            });
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            // Register compoenets here

            // Singleton time provider for the whole container
            builder.RegisterType<TimeProvider>().As<ITimeProvider>().SingleInstance();

            // For integration with ASP.NET Core 3.0+ InstancePerLifetime should be used to achieve InstancePerRequest behaviour
            // See the first dot point here: https://autofaccn.readthedocs.io/en/latest/integration/aspnetcore.html?highlight=UseServiceProviderFactory#differences-from-asp-net-classic
            builder.RegisterType<ExampleService>().As<IExampleService>().InstancePerLifetimeScope();
            builder.RegisterType<ExampleProvider>().As<IExampleProvider>();

            builder.RegisterAssemblyModules(typeof(Startup).Assembly);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "AutofacExample.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
