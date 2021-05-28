using System;

namespace basic_lesson2_solution2
{
    /*
     * Задание 2
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Требуется:
    Создать класс ConvertToer.
    В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента,
    и инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне – public
    ConvertToer(double usd, double eur, double rub).
    Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют,
    также программа должна производить конвертацию из указанных валют в гривну.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(10, 10, 10);
        }
    }
}
