using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    /*
     * Задание 1
    Создайте Web API-приложение. Разработайте для него небольшую клиентскую часть произвольного
    содержания. Подключите к вашему приложения модуль адаптивной верстки bootstrap.

    Задание 2
    Разработайте приложение на базе Razor-страниц. Реализуйте две страницы произвольного характера.
    На каждой из страниц должно быть по кнопке. При нажатии на кнопки будет производится
    переадресация страниц друг на друга.
    */

namespace ASP.NETcore_lesson9
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
