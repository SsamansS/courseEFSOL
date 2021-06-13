using System;
using System.IO;
using System.Xml.Serialization;

/*
 * Задание 2
Создайте класс, поддерживающий сериализацию. Выполните сериализацию объекта этого
класса в формате XML. Сначала используйте формат по умолчанию, а затем измените его
таким образом, чтобы значения полей сохранились в виде атрибутов элементов XML. 
*/
namespace prof_lesson8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(MyClass));
            Serializ(serializer);
        }
        static void Serializ(XmlSerializer serializer)
        {
            MyClass instance = new MyClass();
            for (int i = 0; i < 10; i++)
            {
                instance.ListField.Add(i * 100);
            }

            FileStream stream = new FileStream("Serialization.xml", FileMode.Create, FileAccess.Write, FileShare.Read);
            serializer.Serialize(stream, instance);
            Console.WriteLine("serialized");
            stream.Close();
        }
    }
}
