using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETcore_lesson2_2
{
    public class Company
    {
        // делегат, который будет содержать в себе ссылку на следующий компонент конвейера запросов
        private readonly RequestDelegate next;
        public string Name { get; set; }

        // в конструкторе передается делегал со ссылкой на компонент конвейера запросов
        public Company(RequestDelegate next)
        {
            this.next = next;
            this.Name = "Google";//"nameeeee";
        }

        // метод, выполняющий работу. Должен быть имени Invoke или InvokeAsync!
        public async Task InvokeAsync(HttpContext context)
        {
            // получаем тип запроса
            string method = context.Request.Method;
            if (method == "GET")
            {
                // если GET - отправляем ответ со следующим содержимым и статус-кодом 200
                context.Response.StatusCode = 200;
                await context.Response.WriteAsync($"Name = {this.Name}");
            }
            // в противном случае - передает наш контекст полученного запроса на следующий элемент конвейера
            // потому он, собственно говоря, и называется конвейером запросов
            else
                await next.Invoke(context);
        }
    }
}
