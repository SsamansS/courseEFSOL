using basic_lesson4_solution2.KindOfHandler;
using System;

namespace basic_lesson4_solution2
{
    /*
     * Задание 2
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Требуется:
    Создайте класс AbstractHandler.
    В теле класса создать методы void Open(), void Create(), void Chenge(), void Save().
    Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса
    AbstractHandler.
    Написать программу, которая будет выполнять определение документа и для каждого формата должны
    быть методы открытия, создания, редактирования, сохранения определенного формата документа. 
    */
    class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler XMLhandler = new XMLHandler();
            XMLhandler.Show();
            AbstractHandler TXThandler = new TXTHandler();
            TXThandler.Show();
            AbstractHandler DOChandler = new DOCHandler();
            DOChandler.Show();
        }
    }
}
