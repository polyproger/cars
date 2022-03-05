using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using car.Data.interfaces;
using car.Data.mocks;
using Microsoft.OpenApi.Models;

namespace car
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().Services
                    .AddTransient<IAllCars, MockCars>()
                    .AddTransient<ICarsCategory, MockCategory>()
                    .AddSwaggerGen(c =>   
                    {
                        c.SwaggerDoc("v1", new OpenApiInfo { Title = "Slava Ukraine", Version = "1.0.0" });
                        c.EnableAnnotations();
                    });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage()
               .UseSwagger()
               .UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Dewlad.ID.Api 2.0.0"))
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
    

