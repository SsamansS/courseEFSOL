﻿using System;

namespace basic_lesson2_solution3
{
    /*
     * Задание 3
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Требуется:
    Создать класс Employee.
    В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, и
    инициализирует поля, соответствующие фамилии и имени сотрудника.
    Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый
    сбор.
    Написать программу, которая выводит на экран информацию о сотруднике (фамилия, имя, должность),
    оклад и налоговый сбор.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Employer employer = new Employer("sd", "sdsd");
            employer.Show();
        }
    }
}
