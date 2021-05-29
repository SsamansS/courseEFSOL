using System;

namespace basic_lesson7_solution2
{
    /*
     * Задание 2
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Требуется: Описать структуру с именем Train, содержащую следующие поля: название пункта
    назначения, номер поезда, время отправления.
    Написать программу, выполняющую следующие действия:
    - ввод с клавиатуры данных в массив, состоящий из восьми элементов типа Train (записи должны быть
    упорядочены по номерам поездов);
    - вывод на экран информации о поезде, номер которого введен с клавиатуры (если таких поездов нет,
    вывести соответствующее сообщение).
    */

    class Program
    {
        static void Main(string[] args)
        {
            TrainArray trainArray = new TrainArray();
            Console.WriteLine("Введите номер поезда");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(trainArray.GetTrain(num));
        }
    }
}
