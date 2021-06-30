using System;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;

/*
 * Задание 3
Создайте проект по шаблону "Console Application". Создайте метод «private static int[]
SortArray(bool isAscending, params int[] array)». Метод должен отсортировать массив и вернуть
отсортированный массив в виде результата. Если параметр isAscending равен true - сортировать
по возрастанию, если false - сортировать по убыванию. Как организовать алгоритм сортировки,
полностью зависит от вашего выбора. Вызвать метод SortArray в контексте задачи для большого
массива типа int. Результат задачи обработать в продолжении, где нужно вывести на экран
консоли все элементы массива через запятую.
*/

namespace AsyncP_lesson2_3
{
    public class DescendingComparer : IComparer
    {
        readonly CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();

        public int Compare(object x, object y)
        {
            int result = comparer.Compare(y, x);
            return result;
        }
    }
    public struct Box
    {
        public bool isAscending;
        public int[] array;
        public Box(bool IsAscending, params int[] Array)
        {
            this.isAscending = IsAscending;
            this.array = Array;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Task<int[]> task1 = new Task<int[]>(SortArray, new Box(false, 1, 3, 32, -32, 32, 45, 6, 06, -434));
            task1.Start();

            Task task2 = new Task(new Action(() => WriteChar(task1.Result.Length)));
            task2.Start();

            foreach (int item in task1.Result)
            {
                Thread.Sleep(500);
                Console.Write(item);
            }
        }

        private static void WriteChar(int len)
        {
            Thread.Sleep(500);
            for (int i = 0; i < len; i++)
            {
                Thread.Sleep(500);
                Console.Write(", ");
            }
            Console.WriteLine("Метод " + nameof(WriteChar) + " выполнен");
        }

        private static int[] SortArray(object arg)
        {
            Box box = (Box)arg;
            return SortArray(box.isAscending, box.array);
        }
        private static int[] SortArray(bool isAscending, params int[] array)
        {
            if (isAscending == true)
            {
                Array.Sort(array);
                return array;
            }
            Array.Sort(array, new DescendingComparer());
            return array;
        }
    }
}
