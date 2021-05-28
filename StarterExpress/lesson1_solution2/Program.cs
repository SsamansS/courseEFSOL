using System;

namespace basic_lesson1_solution2
{
    /*
     * Задание 2
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Требуется: Создать класс с именем Rectangle.
        В теле класса создать два поля, описывающие длины сторон double side1, side2.
    Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого
    поля side1 и side2 инициализируются значениями аргументов.
    Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр
    прямоугольника - double PerimeterCalculator().
    Создать два свойства double Area и double Perimeter с одним методом доступа get.
    Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит
    на экран периметр и площадь.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ширину прямоугольника");
            double side1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту прямоугольника");
            double side2 = double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);
            Console.WriteLine($"Площадь прямоугольника = {rectangle.Area}");
            Console.WriteLine($"Периметр прямоугольника = {rectangle.Perimeter}");
        }
    }
}
