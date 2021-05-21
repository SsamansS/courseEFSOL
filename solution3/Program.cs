using System;

namespace lesson9_solution3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 32, 0, 32, 3, 2, 1 };
            foreach (int i in SubArray(array, 2, 9))
            {
                Console.WriteLine(i);
            }
        }
        static int[] MyReverse(int[] array)
        {
            int[] arr = new int[array.Length];
            for (int item = 0; item < array.Length; item++)
            {
                arr[item] = array[array.Length - 1 - item];
            }

            return arr;
        }

        /*static int[] SubArray(int[] array, int index, int count)
        {
            int[] arr = new int[count];
            for(int i = 0; i<count;i++)
            {
                if (i >= index && i < count)
                {
                    

                }
                else
                    arr[i] = 1;
            }
            return array;
        }*/

    }
}
