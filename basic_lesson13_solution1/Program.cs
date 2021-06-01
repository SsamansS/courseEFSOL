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
            Thread myThread = new Thread(new ThreadStart(PrintColumn));
            myThread.Start(); // запускаем поток

            Monitor.Enter(locker);


            while (true)
            {
                PrintColumn();
                Thread.Sleep(300);
                Console.Clear();
            }

            //foreach (var item in Enumerable.Range(1, 100))
            //{
            //    new Thread(PrintColumn).Start();
            //}

        }

        static void PrintColumn()
        {
            Random random = new Random();
            int len = random.Next(0, Console.WindowHeight);
            int indent = random.Next(0, Console.WindowWidth);
            for (int i = 0;  i < len; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                if (i == len - 1) { Console.ForegroundColor = ConsoleColor.White; }
                if (i == len - 2) { Console.ForegroundColor = ConsoleColor.Green; }

                Console.SetCursorPosition(len, indent + i);
                Console.Write(GetRandomChar());

                Console.WriteLine($"{new string(' ', indent)}{GetRandomChar()}");
                Console.ResetColor();
            }
        }
        static char GetRandomChar()
        {
            Random random = new Random();
            string s = random.ToString().ToUpper();
            char c = s[random.Next(0, s.Length - 1)];
            return c;
        }



















        /*
        static readonly object locker = new object();  //Объект синхронизации доступа к разделяемому ресурсу (объект блокировки)

        static void Main(string[] args)
        {
            Console.SetWindowSize(100, 30);
            Console.OutputEncoding = Encoding.UTF8;
            Console.CursorVisible = false;

            foreach (var item in Enumerable.Range(1, 100))
            {
                new Thread(NewMatrix).Start();
            }
        }
        static void NewMatrix()
        {
            string yMatrix = " ";
            int xPosition, yPosition, sleep, length;

            while (true)
            {
                xPosition = new Random().Next(0, Console.WindowWidth);
                yPosition = 0;
                sleep = new Random().Next(50, 500);
                length = new Random().Next(3, 10);

                while (true)
                {
                    for (var i = 0; i < length; i++)
                        yMatrix += ((char)new Random().Next(33, 126)).ToString();

                    lock (locker)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        for (var i = 0; i < length; i++)
                        {
                            if (i == length - 2) Console.ForegroundColor = ConsoleColor.Green;
                            if (i == length - 1) Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(xPosition, yPosition + i);
                            Console.Write(yMatrix[i]);
                        }

                        if (yPosition++ >= Console.WindowHeight - length - 1)
                        {
                            for (var i = 0; i < length; i++)
                            {
                                Console.SetCursorPosition(xPosition, yPosition + i);
                                Console.Write(' ');
                            }
                            break;
                        }
                    }
                    yMatrix = " ";
                    Thread.Sleep(sleep);
                }
            }
        }*/
    }
}
