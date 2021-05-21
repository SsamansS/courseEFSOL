using System;

namespace lesson5_solution3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;
            int z = 15;

            Console.WriteLine(x += y >> x++ * z);
            Console.WriteLine(z = ++x & y * 5);
            Console.WriteLine(y /= x + 5 | z);
            Console.WriteLine(z = x++ & y * 5);
            Console.WriteLine(x = y << x++ ^ z);
        }
    }
}
