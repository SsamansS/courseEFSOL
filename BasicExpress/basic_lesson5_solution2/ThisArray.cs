using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_lesson5_solution2
{
    class ThisArray
    {
        int[] array;
        int MaxV;
        int MinV;
        double Sum = 0;
        double ArithmeticMean;
        List<int> OddNumbers = new List<int> { -1};

        public int[] Array { get => array; set => array = value; }

        public ThisArray(int nd)
        {
            int[] Array = new int[nd];
            array = Array;
        }
        //private void Initialization()
        //{
        //    Random random = new Random();
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        array[i] = random.Next(1, 6);
        //    }
        //}

        void Processing()
        {
            MinV = array[0];
            foreach (int item in array)
            {
                if (item % 2 != 0 && OddNumbers.Contains(item) == false)
                    OddNumbers.Add(item);
                if (item > MaxV)
                    MaxV = item;
                if (item < MinV)
                    MinV = item;

                Sum += item;
            }
            ArithmeticMean = Sum / array.Length;
        }

        void ShowOddItems()
        {
            Console.WriteLine("\nНечетные элементы массива:");
            for (int i = 1; i < OddNumbers.Count; i++)
            {
                Console.Write($"{OddNumbers[i]}  ");
            }
        }

        public void Show()
        {
            Processing();
            Console.WriteLine("Ваш массив:");
            foreach (int i in array)
            {
                Console.Write($"{i}  ");
            }
            Console.WriteLine(@$"
Максимальный элемент: {MaxV}
Минимальный элемент: {MinV}
Сумма элементов: {Sum}
Среднее арифметическое элементов: {ArithmeticMean}");
            ShowOddItems();
        }

    }
}
