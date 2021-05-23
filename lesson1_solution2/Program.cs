using System;

namespace basic_lesson1_solution2
{
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
