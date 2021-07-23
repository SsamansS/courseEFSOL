using System;

    /*
     * Задание 3
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Создайте анонимный метод, который принимает в качестве аргумента массив делегатов и возвращает
    среднее арифметическое возвращаемых значений методов, сообщенных с делегатами в массиве.
    Методы, сообщенные с делегатами из массива, возвращают случайное значение типа int.
    */

namespace basic_lesson9_solution3
{
    public delegate double MyDelegate();
    public delegate double MyDelegatess(MyDelegate[] myDelegates);

    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate = () => 
            {
                Random random = new Random();
                return 31;// random.Next(1,7);
            };



            MyDelegate[] myDelegates = { myDelegate, myDelegate };

            MyDelegatess myDelegates1 = (myDelegates) =>
            {
                return (myDelegates[0].Invoke() + myDelegates[1].Invoke()) / myDelegates.Length ;
            };


            Console.WriteLine(myDelegates1.Invoke(myDelegates));
        }
    }
}
