using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

/*
 * Задание 2
    Создайте проект по шаблону "Console Application". Создайте свой планировщик задач,
    производный от класса TaskScheduler с названием StackTaskScheduler. Ваш планировщик будет
    выполнять первоочередно только поступившие задачи, то есть самые «свежие». Поэтому, внутри
    него используйте для хранения задач коллекцию Stack<T>. Реализуйте добавление задачи при
    запуске в вашу коллекцию.
    Также, вам необходимо создать метод, который будет перебирать коллекцию задач и изымать
    задачи на выполнение.
    Создайте коллекцию задач из 40 задач. Каждая из задач должна вывести на экран консоли, что
    она выполнилась и свой порядковый номер при запуске. Запустите все задачи в цикле с вашим
    планировщиком. Посмотрите на результат работы.
*/

namespace AsyncP_lesson3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Id потока метода Main - {Thread.CurrentThread.ManagedThreadId}");

            Task[] tasks = new Task[40];
            StackTaskScheduler stackTaskScheduler = new StackTaskScheduler();

            for (int i = 0; i < 40; i++)
            {
                //Action action = new Action(() =>
                //{
                //    Console.WriteLine($"Задача {Task.CurrentId} выполнилась в потоке {Thread.CurrentThread.ManagedThreadId}\n");
                //});

                tasks[i] = new Task(() =>
                {
                    Console.WriteLine($"Задача {Task.CurrentId} выполнилась в потоке {Thread.CurrentThread.ManagedThreadId}\n");
                });
                tasks[i].Start(stackTaskScheduler);
            }
            try
            {
                Task.WaitAll(tasks);
            }
            catch
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Несколько задач были отменены!");
                Console.ResetColor();
            }
            finally
            {
                Console.WriteLine($"Метод Main закончил свое выполнение");
            }

            //Med();

            Console.ReadKey();
        }
        static void Med()
        {
            Stack<int> list = new Stack<int>();
            list.Push(2);
            list.Push(4);
            int a = list.Pop();
            Console.WriteLine(a);
        }
    }
}
