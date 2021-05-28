using System;

namespace lesson6_lesson9_solution3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Прямоугольник:\n{Rectangle()}");
            Console.WriteLine($"Прямоугольный треугольник:\n{RightTriangle()}");
            Console.WriteLine($"Равносторнонний треугольник:\n {EquilateralTriangle()}");
            Console.WriteLine($"Ромб:\n{Rhombus()}");
        }

        static string StringMultiplication(int NumberOfLines, string line)
        {
            if (NumberOfLines == 0)
                return line;
            else
            {
                string Line = "";
                for (int i = 0; i < NumberOfLines; i++)
                {
                    Line += line;
                }
                return Line;
            }
        }
        static string Rectangle()
        {
            string response = "";

            int width = 18;
            int height = 11;

            response += StringMultiplication(width + 1, "*") + "\n";

            for (int i = 0; i < height; i++)
            {
                response += "*";
                response += StringMultiplication(width - 1, " ");
                response += "*\n";
            }

            response += StringMultiplication(width + 1, "*");
            return response;
        }

        static string RightTriangle()
        {
            string response = "*\n";

            int width = 18;

            for (int i = 2; i < width; i++)
            {
                response += "*";
                response += StringMultiplication(i - 1, " ");
                response += "*\n";
            }

            response += StringMultiplication(width + 1, "*");
            return response;
        }

        static string EquilateralTriangle()
        {
            string response = "*\n";

            int width = 18;

            for (int i = 2; i < width/2 + 1; i++)
            {
                response += "*";
                response += StringMultiplication(i - 1, " ");
                response += "*\n";
            }
            for (int i = width/2 - 1; i > -1; i--)
            {
                response += "*";
                response += StringMultiplication(i+1, " ");
                response += "*\n";
            }
            return response + "*";
        }

        static string Rhombus()
        {

            int width = 21;
            int wi = width * 2 - 1;
            string response = StringMultiplication(width + 1, " ") + "**\n";

            for(int i = width; i > 0; i--)
            {
                response += StringMultiplication(i, " ");
                response += "*";
                response += StringMultiplication(2 * (width - i + 1), " ");
                response += "*\n";
            }
            
            for (int i = 1; i <= width; i++)
            {
                response += StringMultiplication(i, " ");
                response += "*";
                response += StringMultiplication(2*(width - i +1), " ");
                response += "*\n";
            }

            return response + StringMultiplication(width + 1, " ") + "**";
        }


    }
}
