using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_lesson1_solution4
{
    class Figure
    {
        string name;
        Point _point1;
        Point _point2;
        Point _point3;
        Point _point4;
        Point _point5;

        public Figure(Point point1, Point point2, Point point3)
        {
            this.name = "треугольник";
            this._point1 = point1;
            this._point2 = point2;
            this._point3 = point3;
            PerimeterCalculator();
        }
        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            this.name = "четырёхугольник";
            this._point1 = point1;
            this._point2 = point2;
            this._point3 = point3;
            this._point4 = point4;
            PerimeterCalculator();
        }
        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            this.name = "пятиугольник";
            this._point1 = point1;
            this._point2 = point2;
            this._point3 = point3;
            this._point4 = point4;
            this._point5 = point5;
            PerimeterCalculator();
        }

        public double LengthSide(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow(point1.x - point2.x, 2) + Math.Pow(point1.y - point2.y, 2));
        }
        public void PerimeterCalculator()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            if(name == "треугольник")
            {
                double a = LengthSide(_point1, _point2) + LengthSide(_point2, _point3) + LengthSide(_point3, _point1);
                Console.WriteLine($"Периметр {name}а = {a}");
            }
            else if(name == "четырёхугольник")
            {
                double a = LengthSide(_point1, _point2) + LengthSide(_point2, _point3) + LengthSide(_point3, _point4) + LengthSide(_point4, _point1);
                Console.WriteLine($"Периметр {name}а = {a}");
            }
            else if (name == "пятиугольник")
            {
                double a = LengthSide(_point1, _point2) + LengthSide(_point2, _point3) + LengthSide(_point3, _point4) + LengthSide(_point4, _point5) + LengthSide(_point5, _point1);
                Console.WriteLine($"Периметр {name}а = {a}");
            }
        }

    }
}
