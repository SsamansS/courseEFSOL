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
    Задайте путь маршрутизации, который принимает множественный параметр и последовательно
    выводит в окно браузера только те значения сегментов, которые содержат в себе цифры. Если же таких
    значений нет, или параметр пуст, должна быть выведена ошибка
    */
namespace ASP.NETcore_lesson4_2
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
