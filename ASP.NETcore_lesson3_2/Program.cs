using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    /*
     * Задание 2
    Создайте небольшой сервис с жизненным циклом Transient. Сервис должен анализировать текущее
    время на сервере и, в зависимости от результата, в форме http-ответа возвращать строку «сейчас день»
    (если время между 12 и 16 часами), «сейчас вечер» (если между 16 и полночью), «сейчас ночь» (от
    полночи до 4 утра) и, соответственно, «сейчас утро» (от 4 до 12)
    */

namespace ASP.NETcore_lesson3_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
