using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

    /*
     * Задание 2
    Создайте консольное приложение, в котором организуйте асинхронный вызов метода.
    Используя конструкцию BeginInvoke передайте в поток некоторую информацию (возможно, в
    формате строки). Организуйте обработку переданных данных в callback методе. 
    */

namespace prof_lesson13_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First thread with ID {0} start", Thread.CurrentThread.ManagedThreadId);

            Action myDelegate = new Action(Method);
            AsyncCallback asyncCallback = new AsyncCallback(Callback);

            IAsyncResult asyncResult = myDelegate.BeginInvoke(asyncCallback, "stringi");

            myDelegate.EndInvoke(asyncResult);

            Console.WriteLine("First thread with ID {0} finished", Thread.CurrentThread.ManagedThreadId);
        }

        private static void Callback(IAsyncResult asyncResult)
        {
            Console.WriteLine("Callback method in thread with ID {0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Callback method's AsyncStat = {0}", asyncResult.AsyncState);
        }

        static void Method()
        {
            Console.WriteLine("Second thread with ID {0} start", Thread.CurrentThread.ManagedThreadId);
            for (int i = 0; i < 80; i++)
            {
                Console.Write(++i);
            }
            Console.WriteLine("Second thread with ID {0} finished", Thread.CurrentThread.ManagedThreadId);
        }
    }
}
