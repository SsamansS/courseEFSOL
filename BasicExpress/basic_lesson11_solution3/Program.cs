﻿using System;
using System.Collections.Generic;

/*
 * Задание 3
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте класс MyDictionary<TKey,TValue>. Реализуйте в простейшем приближении возможность
использования его экземпляра аналогично экземпляру класса Dictionary (Урок 6 пример 5).
Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод
добавления пар элементов, индексатор для получения значения элемента по указанному индексу и
свойство только для чтения для получения общего количества пар элементов. 
*/

namespace basic_lesson11_solution3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dsfs = new Dictionary<string, string>(4);
            dsfs.Add("key", "value");
            Console.WriteLine(dsfs["key"]);
            Console.WriteLine(dsfs.Count);
        }
    }
}
