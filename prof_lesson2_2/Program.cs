using System;
using System.Collections;
using System.Collections.Immutable;
using System.Collections.Specialized;

/*
 * Задание 2
Создайте коллекцию, в которую можно добавлять покупателей и категорию приобретенной ими
продукции. Из коллекции можно получать категории товаров, которые купил покупатель или по
категории определить покупателей. 
*/

namespace prof_lesson2_2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Customers customers = new Customers();
            //customers["3"] = "342";
            customers.Add("red", "rojo");
            customers.Add("green", "rojo");
            customers.Add("blue", "rojo");
            customers.Add("red", "rouge");

            foreach (var i in customers.GetCategories("rojo"))
            {
                Console.WriteLine(i);
            }

        }
    }
}
