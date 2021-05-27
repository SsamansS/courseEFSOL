using System;

namespace basic_lesson9_solution3
{
    /*
     * Задание 3
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Создайте анонимный метод, который принимает в качестве аргумента массив делегатов и возвращает
    среднее арифметическое возвращаемых значений методов, сообщенных с делегатами в массиве.
    Методы, сообщенные с делегатами из массива, возвращают случайное значение типа int.
    */
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
