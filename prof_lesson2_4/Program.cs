using System;
using System.Collections.Specialized;

/*
 * Задание 4
Создайте коллекцию типа OrderedDictionary и реализуйте в ней возможность сравнения значений
ключей.
*/

namespace prof_lesson2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyOrderedDictionary ordered = new MyOrderedDictionary();
            ordered.Add("red", "rojo");
            ordered.Add("green", "rojo");
            ordered.Add("blue", "rojo");
            //ordered.Add("red", "rouge");

            MyOrderedDictionary ordered1 = new MyOrderedDictionary();
            ordered1.Add("red", "rojo");
            ordered1.Add("green", "rojo");
            ordered1.Add("blue", "rojo");
            //ordered1.Add("red", "rouge");
            Console.WriteLine(ordered.Equals(ordered1.Keys));
        }
    }
}
