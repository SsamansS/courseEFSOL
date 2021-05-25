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
            ThisArray array = new ThisArray();
            array[0] = 23;
            array[1] = 21;
            array[2] = -3;
        }
    }
}
