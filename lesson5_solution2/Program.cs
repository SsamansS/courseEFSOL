using System;

namespace lesson5_solution2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, которое нужно проверить на четность");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine($"Решение без перевода числа в байты: {WithoutBitwise(a)}");
            Console.WriteLine($"Решение с переводом числа в байты: {Bitwise(a)}");

        }

        static string Bitwise(int a)
        {
            string a_bool = Convert.ToString(a, 2);
            if (a_bool[a_bool.Length - 1] == '0')
                return $"число {a} - четное";
            else
                return $"число {a} - нечетное";
        }

        static string WithoutBitwise(int a)
        {
            if (a%2 == 0)
                return $"число {a} - четное";
            else
                return $"число {a} - нечетное";
        }
    }
}
