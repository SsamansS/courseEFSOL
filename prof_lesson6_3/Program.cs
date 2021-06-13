using System;
using System.Reflection;

    /*
     * Задание 3
    Создайте программу, в которой предоставьте пользователю доступ к сборке из Задания 2.
    Реализуйте использование метода конвертации значения температуры из шкалы Цельсия в
    шкалу Фаренгейта. Выполняя задание используйте только рефлексию. 
    */
namespace prof_lesson6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.Load("prof_lesson6_2");

            dynamic instance = Activator.CreateInstance(assembly.GetType("prof_lesson6_2.Temperature"));

            Console.WriteLine("15 °C по °F равно " + instance.Fahrenheit(15m));

            Console.ReadKey();
        }
    }
}
