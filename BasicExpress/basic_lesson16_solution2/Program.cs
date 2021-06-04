using System;

/*
 * Задание 2
Создайте класс Block с 4-мя полями сторон, переопределите в нем методы:
Equals – способный сравнивать блоки между собой,
ToString – возвращающий информацию о полях блока.
*/

namespace basic_lesson16_solution2
{
    class Program
    {
        static void Main(string[] args)
        {
            Block block = new Block();
            block.index = 12;
            block.area = 45;
            block.city = "bish";
            block.country = "kg";

            Block block1 = block;
            Console.WriteLine(block1.ToString());
        }
    }
}
