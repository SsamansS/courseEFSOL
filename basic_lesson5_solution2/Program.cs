using System;

namespace basic_lesson5_solution2
{
    /*
     * Задание 2
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Требуется:
    Создать массив размерностью N элементов, заполнить его произвольными целыми значениями.
    Вывести наибольшее значение массива, наименьшее значение массива, общую сумму элементов,
    среднее арифметическое всех элементов, вывести все нечетные значения.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Задайте длину одномерного массива плз: ");
            int n = int.Parse(Console.ReadLine());

            ThisArray arr = new ThisArray(n);

            Random random = new Random();
            for (int i = 0; i < arr.Array.Length; i++)
            {
                arr.Array[i] = random.Next();
            }

            arr.Show();
        }
    }
}
