using System;
using System.Collections.Generic;

/*
 * Задание 2
Выучите описание шаблона Template method (Шаблонный метод). Обратите внимание на
применимость шаблона, а также на состав его участников и связи отношения между ними.
Напишите небольшую программу на языке C#, представляющую собой абстрактную
реализацию данного шаблона. 
*/

namespace prof_lesson10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Phone> phones = new List<Phone> { new IPhone(), new SamsungGalaxy() };
            foreach (var phone in phones)
                phone.GetInfo();
        }
    }

    abstract class Phone
    {
        public void GetInfo()
        {
            Console.WriteLine("Производитель: " + GetManufacturer());
            Console.WriteLine("ОС:            " + GetOS());
        }
        abstract public string GetManufacturer();
        abstract public string GetOS();
    }
    class IPhone : Phone
    {
        public override string GetManufacturer()
        {
            return "Apple";
        }
        public override string GetOS()
        {
            return "IOS";
        }
    }
    class SamsungGalaxy : Phone
    {
        public override string GetManufacturer()
        {
            return "Samsung";
        }
        public override string GetOS()
        {
            return "Android";
        }
    }
}
