using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Rehber.Business.Abstract;
using Rehber.Business.Concrete;
using Rehber.DataAccess.Abstract;
using Rehber.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rehber.API
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
            services.AddSingleton<IRehberKService, RehberKManager>();
            services.AddSingleton<IRehberKDetailService, RehberKDetailManager>();
            services.AddSingleton<IRehberKRepository, RehberKRepository>();
            services.AddSingleton<IRehberKDetailRepository, RehberKDetailRepository>();
            services.AddSwaggerDocument( config => {
                config.PostProcess = (doc =>
                {
                    doc.Info.Title = "Rise Consulting Rehber API";
                    doc.Info.Version = "16.01.22";
                    doc.Info.Contact = new NSwag.OpenApiContact()
                    {
                        Name = "Ahmet Selçuk Tepe",
                        Email = "ahmetselcuktepe@gmail.com"
                    };
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();
            app.UseOpenApi();
            app.UseSwaggerUi3();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
