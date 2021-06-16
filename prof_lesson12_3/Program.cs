using System;
using System.Threading;

        /*
         * Задание 3
        Создайте приложение, которое может быть запущено только в одном экземпляре (используя
        именованный Mutex). 
        */

namespace prof_lesson12_3
{
    class Program
    {
        static Mutex mutex = new Mutex(false, "MyMutex");
        static void Main(string[] args)
        {
            Thread thread = new Thread(Process);
            thread.Start();
            Console.ReadKey();
        }
        static void Process()
        {
            mutex.WaitOne();
            Console.WriteLine("start");
            mutex.ReleaseMutex();
            Console.WriteLine("finish");
        }
    }
}
