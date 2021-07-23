using System;
using System.Linq;
using System.Text;
using System.Threading;


/*
 * Задание 1
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу, которая будет выводить на экран цепочки падающих символов. Длина каждой
цепочки задается случайно. Первый символ цепочки – белый, второй символ – светло-зеленый,
остальные символы темно-зеленые. Во время падения цепочки, на каждом шаге, все символы меняют
свое значение. Дойдя до конца, цепочка исчезает и сверху формируется новая цепочка. Смотрите ниже
снимок экрана, представленный как образец. 
*/

namespace basic_lesson13_solution1
{
    class Program
    {
        static object locker = new object();
        static void Main(string[] args)
        {


            //foreach (var item in Enumerable.Range(1, 100))
            //{
                new Thread(PrintColumn).Start();
            //}

        }

        static void PrintColumn()
        {
            while (true)
            {
                Random random = new Random();
                int len = random.Next(3, Console.WindowHeight);
                int indent = random.Next(0, Console.WindowWidth);
                    lock (locker)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        for (int i = 0; i < len; i++)
                        {
                            if (i == len - 1) { Console.ForegroundColor = ConsoleColor.White; }
                            if (i == len - 2) { Console.ForegroundColor = ConsoleColor.Green; }

                            Console.SetCursorPosition(len, indent + i);
                            string str = $"{new string(' ', indent)}{GetRandomChar()}";

                            Console.WriteLine(str);
                            str = $"{new string(' ', indent)} ";
                        Console.ResetColor();
                        }
                        if (indent++ >= Console.WindowHeight - len - 1)
                        {
                            for (var i = 0; i < len; i++)
                            {
                                Console.SetCursorPosition(len, indent + i);
                                Console.Write(' ');
                            }
                            break;
                        }
                        Thread.Sleep(300);
                    }
                
            }
        }
        static char GetRandomChar()
        {
            Random random = new Random();
            string s = random.ToString().ToUpper();
            char c = s[random.Next(0, 9)];//s.Length - 1)];
            return c;
        }
    }
}
