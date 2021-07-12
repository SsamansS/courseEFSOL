using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETcore_lesson3_2
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        TimeNow timeNow = new TimeNow();

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.Run(async (context) =>
            {
                if (timeNow.timeNow > DateTime.Today.Date.Add(new TimeSpan(12, 00, 00)) && timeNow.timeNow <= DateTime.Today.Date.Add(new TimeSpan(16, 00, 00)))
                    await context.Response.WriteAsync("it is day now");
                else if (timeNow.timeNow > DateTime.Today.Date.Add(new TimeSpan(16, 00, 00)) && timeNow.timeNow <= DateTime.Today.Date.Add(new TimeSpan(22, 00, 00)))
                    await context.Response.WriteAsync("it is evening now");
                else if (timeNow.timeNow > DateTime.Today.Date.Add(new TimeSpan(22, 00, 00)) && timeNow.timeNow <= DateTime.Today.Date.Add(new TimeSpan(4, 00, 00)))
                    await context.Response.WriteAsync("it is night now");
                else
                    await context.Response.WriteAsync("it is morning now");
            });
        }
    }
}
