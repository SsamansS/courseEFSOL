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
            ThisArray arr = new ThisArray(4);
            //arr.array = new ThisArray(3);
            arr[0] = 23;
            arr[1] = 21;
            arr[2] = -3;
            /*for(int i = 0; i < arr.array.Length; i++)
            {

            }*/
            foreach(int i in arr.Array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(arr[0]);
        }
    }
}
