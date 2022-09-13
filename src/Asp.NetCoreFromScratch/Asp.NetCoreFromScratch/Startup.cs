using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.NetCoreFromScratch;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

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
            services.AddTransient<CustomMiddleware1>();

        }

        

        

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {



             //app.Run(async context =>
             //{
             //    await context.Response.WriteAsync("Hello from Run");
             //});

            // app.Use(async (context, next) =>
            // {
            //     await context.Response.WriteAsync("Hello from Use-1 1 \n");

            //     await next();

            //     await context.Response.WriteAsync("Hello from Use-1 2 \n");
            // });

            //app.Map("/kk", CutomCode);

            //app.Run(async context =>
            // {
            //     await context.Response.WriteAsync("Hello from Run \n");
            // });

            //app.UseMiddleware<CustomMiddleware1>();



        if (env.IsDevelopment())
            { 
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hi Web Api project");
                });
                   
            });
        }

        private void CutomCode(IApplicationBuilder app)
        {
                app.Run(async context => {
                    await context.Response.WriteAsync("Hello from kk \n");
                });
        }
    }
