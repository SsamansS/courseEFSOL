using System;
using System.Threading;
using System.Threading.Tasks;

/*
 * Задание 2
Создайте приложение по шаблону Console Application. Создайте метод с названием CalculateFactorial,
который считает факториал переданного в параметрах числа и возвращает результат. Создайте
асинхронный метод с названием CalculateFactorialAsync, который асинхронно, в контексте задачи
выполняет метод CalculateFactorial, но не возвращает значение факториала, а выводит его на экран
консоли. Вызовите из метода Main асинхронный метод CalculateFactorialAsync, не блокируя работу
метода Main. Для проверки, в методе Main выводите в цикле на экран консоли какие-то символы, пока
асинхронный метод выполняется.
*/

namespace AsyncP_lesson4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Метод Main начал свою работу в потоке {Thread.CurrentThread.ManagedThreadId}.");

            CalculateFactorialAsync(7);
            WriteChar('*');

            Console.WriteLine($"Метод Main закончил свою работу в потоке {Thread.CurrentThread.ManagedThreadId}.");
        }
        private static void WriteChar(char sym)
        {
            for (int i = 0; i < 80; i++)
            {
                Console.Write(sym);
            }
            Console.WriteLine("\nМетод " + nameof(WriteChar) + " выполнен");
        }
        static long CalculateFactorial(long num)
        {
            if (num == 1)
                return 1;
            else
                return num * CalculateFactorial(num - 1);
        }
        static async void CalculateFactorialAsync(long num)
        {
            Console.WriteLine($"Метод CalculateFactorialAsync начал свою работу в потоке {Thread.CurrentThread.ManagedThreadId}.");

            Console.ForegroundColor = ConsoleColor.Green;
            await Task.Run(() => Console.Write(CalculateFactorial(num)));
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine($"Метод CalculateFactorialAsync закончил свою работу в потоке {Thread.CurrentThread.ManagedThreadId}.");
        }
    }
}
