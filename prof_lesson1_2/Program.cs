using prof_lesson1_2.Mon;
using System;

    /*
     * Задание 2
    Создайте коллекцию, в которой бы хранились наименования 12 месяцев, порядковый номер и
    количество дней в соответствующем месяце. Реализуйте возможность выбора месяцев, как по
    порядковому номеру, так и количеству дней в месяце, при этом результатом может быть не
    только один месяц.
    */


namespace prof_lesson1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Months months = new Months();
            Console.WriteLine(months.GetMonth(12));
            Console.WriteLine("Hello World!");
            foreach(string i in months.SearchMonths(30))
            {
                Console.WriteLine(i);
            }
        }
    }
}
