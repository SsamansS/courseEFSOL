using System;

namespace basic_lesson3_solution3
{
    /*
     * Задание 3
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Требуется:
    Создать класс Vehicle.
    В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год
    выпуска).
    Создайте 3 производных класса Plane, Саг и Ship.
    Для класса Plane должна быть определена высота и количество пассажиров.
    Для класса Ship — количество пассажиров и порт приписки.
    Написать программу, которая выводит на экран информацию о каждом средстве передвижения.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Realization realization = new Realization();
            realization.Show();
        }
    }
}
