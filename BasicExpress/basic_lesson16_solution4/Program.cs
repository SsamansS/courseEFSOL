using System;

    /*
     * Задание 4
    Создайте класс, который будет содержать информацию о дате (день, месяц, год). С помощью
    механизма перегрузки операторов, определите операцию разности двух дат (результат в виде
    количества дней между датами), а также операцию увеличения даты на определенное количество дней.
    */

namespace basic_lesson16_solution4
{
    class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date();
            date.Month = 4;
            date.Day = 4;
            date.Year = 2;

            Date date1 = new Date();
            date1.Month = 4;
            date1.Day = 3;
            date1.Year = 2;

            Console.WriteLine(date - date1);

            Date d = date + 30;
            Console.WriteLine(d.Day);
            Console.WriteLine(d.Month);
        }
    }
}
