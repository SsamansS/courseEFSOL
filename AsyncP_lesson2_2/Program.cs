using System;
using System.Threading;
using System.Threading.Tasks;

/*
 * Задание 2
Создайте проект по шаблону "Console Application". Создайте метод «private static void
WriteChar(object symbol)». В теле метода создайте цикл for, размерностью 160 итераций, который
в своем теле с задержкой в пол секунды выводит на экран консоли значение параметра symbol,
приведенного к типу char. Вызовите метод WriteChar из метода Main в контексте задачи,
передавая в качестве параметра значение "!". Все время, пока метод WriteChar выполняется, из
метода Main выводите на экран консоли "$". Когда задача закончит свое выполнение выведите
на экран консоли строку "Метод Main закончил свою работу".
*/

namespace AsyncP_lesson2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Action threadOutput = new Action(() => WriteChar('!'));
            Task task = new Task(threadOutput);
            task.Start();

            WriteChar('$');

            Console.WriteLine("Метод " + nameof(Main) + " выполнен");
        }
        private static void WriteChar(object symbol)
        {
            for(int i = 0; i < 160; i++)
            {
                Thread.Sleep(500);
                Console.Write((char)symbol);
            }
            Console.WriteLine("Метод " + nameof(WriteChar)+ " выполнен выводя: " + (char)symbol);
        }
    }
}
