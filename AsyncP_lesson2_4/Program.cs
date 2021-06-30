using System;
using System.Threading;
using System.Threading.Tasks;

/*
 * Задание 4
Создайте проект по шаблону "Console Application". Создайте метод с именем «private static double
FindLastFibonacciNumber(int number)». Метод должен найти и вернуть последнее число из
последовательности Фибоначчи. Для нахождения последнего числа из последовательности
Фибоначчи в тело метода вставить следующий код:
Func<int, double> fib = null;
fib = (x) => x > 1 ? fib(x - 1) + fib(x - 2) : x;
return fib.Invoke(number);
Даже, если вы считаете, что этот код недостаточно оптимизирован, все равно нужно
использовать его. В этом и смысл, что с помощью такого решения, последовательность числа
Фибоначчи будет находится намного дольше и с более сильной затратой ресурсов. Поэтому, вам
нужно вызвать из метода Main этот метод в контексте задачи. Но так как эта операция займет
много времени, вам нужно использовать флаг TaskCreationOptions.LongRunning, чтобы задача
выполнялась в контексте потока выполнения Thread и не занимала потоки из пула. Результат
асинхронной задачи необходимо вывести на экран консоли. Сделайте это с помощью
продолжения.
*/

namespace AsyncP_lesson2_4
{
    class Program
    {
        struct Box
        {
            public int number;
            public Box(int number)
            {
                this.number = number;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Task<double> task1 = new Task<double>(FindLastFibonacciNumber, new Box(8));
            task1.Start();

            task1.ContinueWith((t) => Continuation(t), TaskContinuationOptions.LongRunning);
            Console.WriteLine("Фибоначи" + task1.Result);

            Console.ReadKey();
        }


        private static double FindLastFibonacciNumber(object obj)
        {
            Box box = (Box)obj;
            return FindLastFibonacciNumber(box.number);
        }
        private static double FindLastFibonacciNumber(int number)
        {
            Func<int, double> fib = null;
            fib = (x) => x > 1 ? fib(x - 1) + fib(x - 2) : x;
            return fib.Invoke(number);
        }
        private static void Continuation(Task task)
        {
            Console.WriteLine($"Id задачи продолжения - {Task.CurrentId}.");
            Console.WriteLine($"Продолжение выполнилось в потоке {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("sdsffffffffrefre");
        }
    }
}
