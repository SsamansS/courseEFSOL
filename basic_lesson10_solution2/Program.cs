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

/*
    * Задание 4
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Создайте расширяющий метод: public static T[] GetArray<T>(this MyList<T> list)
    Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в домашнем задании 2
    для данного урока. Выведите на экран значения элементов массива, который вернул расширяющий
    метод GetArray().
*/

namespace basic_lesson10_solution2and4
{
public static class MyStatClass
{
    public static T[] GetArray<T>(this MyList<T> list)
    {
        return list.List;
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyList<int> List = new MyList<int>(4);

        Console.WriteLine(List.Count);
        Console.WriteLine(List.GetItem(3));
        List.Add(23);

        Console.WriteLine(List.GetItem(List.Count - 1));

        foreach(int i in MyStatClass.GetArray(List))
        {
            Console.WriteLine(i);
        }
    }
}
}
