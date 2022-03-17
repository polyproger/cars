using DependensyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace car
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddBusinessLayer();
            services.AddSwaggerGen(c =>
                    {
                        c.SwaggerDoc("v1", new OpenApiInfo { Title = "Car Api", Version = "2.0.0" });
                        c.EnableAnnotations();
                    });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage()
               .UseSwagger()
               .UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Car.Api 2.0.0"))
               .UseReDoc(c => c.SpecUrl("/swagger/v1/swagger.json"));
            app.UseCors(x => x.AllowAnyOrigin()
                              .AllowAnyMethod()
                              .AllowAnyHeader())
               .UseHttpsRedirection()
               .UseRouting()
               .UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }
}