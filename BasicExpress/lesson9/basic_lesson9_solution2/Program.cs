using System;

    /*
     * Задание 2
        Используя Visual Studio, создайте проект по шаблону Console Application.
        Создайте четыре лямбда оператора для выполнения арифметических действий: (Add – сложение, Sub –
        вычитание, Mul – умножение, Div – деление). Каждый лямбда оператор должен принимать два
        аргумента и возвращать результат вычисления. Лямбда оператор деления должен делать проверку
        деления на ноль.
        Написать программу, которая будет выполнять арифметические действия, указанные пользователем.
    */

namespace basic_lesson9_solution2
{
    public delegate double MyDelegate(double x, double y);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate;
            myDelegate = (x, y) => { return x + y; };

            myDelegate += (x, y) => { return x * y; };

            myDelegate += (x, y) => { return x - y; };

            myDelegate += (x, y) =>
            {
                if (y == 0)
                    return -1;
                else
                    return x / y;
            };
        }
    }
}
