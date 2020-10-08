using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MVC_Calculator.Middleware;
using MVC_Calculator.Services;

namespace MVC_Calculator
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
            services.AddTransient<ICalculationService, CalculationService>();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            /*
            app.Use(async (context, next) =>
            {
                //logic to perform the request
                await context.Response.WriteAsync("<p>This is MiddleWare 1</p>");
                await next();//once done with this middleware, go onto the next middleware
            });

            app.UseAuthentication();
            app.UseAuthorization();

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("<p>This is MiddleWare 2</p>");
                await next();
            });

            app.Map("/darion", action =>
            {
                action.Use(async (context, next) =>
                {
                    await context.Response.WriteAsync("<p>Darion likes middleware</p>");
                    await next();
                });

                action.Use(async (context, next) =>
                {
                    await context.Response.WriteAsync("<p>Bernard likes middleware too</p>");
                    await next();
                });
            });

            app.UseMiddleware<ExceptionHandlingMiddleware>();

            //app.Run is meant to be the last middleware that is run. That's why there isn't a "next" shown
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("<p>This is Run MiddleWare</p>");
            });
            */

            #region Not Using Middleware Section
            
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            
            #endregion
        }
    }
}
