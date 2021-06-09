using System;
using System.IO;
using System.Xml;

    /*
     * Задание 3
    Из файла TelephoneBook.xml (файл должен был быть создан в процессе выполнения
    дополнительного задания) выведите на экран только номера телефонов. 
    */

namespace prof_lesson5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument document = new XmlDocument();

            document.Load(@"D:\C# EFSOL\CourseFromEFSOL\courseEFSOL\prof_lesson5_2\TelephoneBook.xml");

            XmlNode root = document.DocumentElement;

            Console.WriteLine(root.LocalName);

            foreach (XmlNode contacts in root.ChildNodes)
            {
                foreach (XmlNode contact in contacts.ChildNodes)
                {
                    if (contact.Name == "TelephoneNumber")
                    {
                        Console.WriteLine(contact.InnerText);
                    }
                }
            }
        }
    }
}
