using System;

namespace basic_lesson9_solution3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vs = { 1, 2, 32, 322};
            foreach(int i in vs[1..3])
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(vs[1..3]);
        }
    }
}
