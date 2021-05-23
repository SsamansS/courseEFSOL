using System;

namespace basic_lesson1_solution4
{
    /*
     *Задание 4
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Требуется:
    Создать классы Point и Figure.
    Класс Point должен содержать два целочисленных поля и одно строковое поле.
    Создать три свойства с одним методом доступа get.
    Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями
    аргументов. Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти
    аргументов типа Point.
    Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину
    стороны многоугольника; void PerimeterCalculator(), который рассчитывает периметр
    многоугольника.
    Написать программу, которая выводит на экран название и периметр многоугольника.  
    */
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point();
            point1.x = 1;
            point1.y = 1;
            Point point2 = new Point();
            point2.x = 1;
            point2.y = 3;
            Point point3 = new Point();
            point3.x = 3;
            point3.y = 3;
            Point point4 = new Point();
            point4.x = 1;
            point4.y = 3;
            Point point5 = new Point();
            point5.x = 3;
            point5.y = 3;

            Figure figure = new Figure(point1, point2, point3, point4, point5);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
