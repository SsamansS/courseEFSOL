using System;
using System.IO;
using System.Xml;

/*Доп задание:
 * Создайте .xml файл, который соответствовал бы следующим требованиям:
 имя файла: TelephoneBook.xml
 корневой элемент: “MyContacts”
 тег “Contact”, и в нем должно быть записано имя контакта и атрибут “TelephoneNumber”
со значением номера телефона. 
*/

/*
 * Задание 2
Создайте приложение, которое выводит на экран всю информацию об указанном .xml файле.
*/
namespace prof_lesson5_2
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
                Console.WriteLine("Found Contact:");
                foreach (XmlNode contact in contacts.ChildNodes)
                {
                    Console.WriteLine(contact.Name + ": " + contact.InnerText);
                }
                Console.WriteLine(new string('-', 40));
            }
        }
    }
}
