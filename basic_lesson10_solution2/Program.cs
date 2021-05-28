using System;

    /*
     * Задание 2
        Используя Visual Studio, создайте проект по шаблону Console Application.
        Создайте класс MyList<T>. Реализуйте в простейшем приближении возможность использования его
        экземпляра аналогично экземпляру класса List<T>. Минимально требуемый интерфейс
        взаимодействия с экземпляром, должен включать метод добавления элемента, индексатор для
        получения значения элемента по указанному индексу и свойство только для чтения для получения
        общего количества элементов.
    */

namespace basic_lesson10_solution2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> List = new MyList<int>(4);

            Console.WriteLine(List.Count);
            Console.WriteLine(List.GetItem(3));
            List.Add(23);

            Console.WriteLine(List.GetItem(List.Count - 1));
        }
    }
}
