using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETcore_lesson4_2
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var routeBuilder = new RouteBuilder(app);

            routeBuilder.MapRoute("{*catchall}",
                async context =>
                {
                    RouteData data = context.GetRouteData();
                    foreach(var param in data.Values)
                    {
                        string[] Parameters = param.Value.ToString().Split('/');
                        if (new Helper().CheckOnContainsNums(Parameters))
                        {
                            foreach (string Parameter in Parameters)
                            {
                                try
                                {
                                    Convert.ToInt32(Parameter);
                                    await context.Response.WriteAsync(Parameter);
                                }
                                catch
                                {
                                    continue;
                                }
                            }
                        }
                        else
                            await context.Response.WriteAsync("error");
                    }
                });

            app.UseRouter(routeBuilder.Build());

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Default page.");
            });
        }
    }
}
