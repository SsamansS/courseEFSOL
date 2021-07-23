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
    Создайте набор контроллеров, обрабатывающие свои маршруты и возвращающие в качестве ответа
    связанные с ними html-представления

    Задание 2
    Разместите на сервере файл example.txt и попробуйте отправить его клиенту любым желаемым
    способом
    */

namespace ASP.NETcore_lesson8
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
