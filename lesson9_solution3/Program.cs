using System;
using System.Runtime;

namespace lesson9_solution3
{
    class Program
    {

        /*Задание 3
Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Требуется:
1) Создать метод MyReverse(int [] array), который принимает в качестве аргумента массив
целочисленных элементов и возвращает инвертированный массив (элементы массива в обратном
порядке).
2) Создайте метод int [] SubArray(int [] array, int index, int count). Метод возвращает
часть полученного в качестве аргумента массива, начиная с позиции указанной в аргументе index,
размерностью, которая соответствует значению аргумента count.
Если аргумент count содержит значение больше чем количество элементов, которые входят в
выбираемую часть исходного массива (от указанного индекса index, до индекса последнего элемента),
то при формировании нового массива размерностью в count, заполните единицами те элементы,
которые не были скопированы из исходного массива.*/

        static void Main(string[] args)
        {
            int[] array = { 0, 1, 34, 3, 4, 5, 6 };

            Console.WriteLine("подзадача 1:");
            foreach (int i in MyReverse(array))
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\nподзадача 2:");
            foreach (int i in Helper(SubArray(array, 4, 6), 6))
            {
                Console.Write(i + " ");
            }

        }

        static int[] MyReverse(int[] array)
        {
            Array.Reverse(array);
            return array;
        }
        static int[] SubArray(int[] array, int index, int count)
        {
            int[] arr1 = new int[array.Length];

            for(int i = 0; i < array.Length; i++)
            {
                arr1[i] = 1;
            }

            if (count <= array.Length - index)
            {
                Array.ConstrainedCopy(array, index, arr1, 0, count);
                return arr1;
            }
            else
            {
                Array.Resize(ref array, array.Length + 1);
                array[array.Length - 1] = 1;
                return SubArray(array, index, count);
            }
        }

        static int[] Helper(int[] array, int count)
        {
            if(array.Length == count)
            {
                return array;
            }
            else
            {
                Array.Resize(ref array, array.Length - 1);
                return Helper(array, count);
            }
        }
    }
}
