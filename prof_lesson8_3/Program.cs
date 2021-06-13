using System;
using System.IO;
using System.Xml.Serialization;
using prof_lesson8_2;

namespace prof_lesson8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(MyClass));
            Console.WriteLine(PrintDeserializ(serializer));
        }
        static string PrintDeserializ(XmlSerializer serializer)
        {
            string response = "";
            FileStream stream = new FileStream(@"D:\C# EFSOL\CourseFromEFSOL\courseEFSOL\prof_lesson8_2\bin\Debug\net5.0\Serialization.xml", FileMode.Open, FileAccess.Read, FileShare.Read);

            // Восстанавливаем объект из XML-файла.
            MyClass instance = serializer.Deserialize(stream) as MyClass;
            response += "Объект Десериализован!\n\n";


            response += $"{nameof(instance.IntField)}: " + instance.IntField + Environment.NewLine +
                            $"{nameof(instance.StringField)}: " + instance.StringField + Environment.NewLine +
                            $"{nameof(instance.ListField)}: " + Environment.NewLine;

            foreach (int item in instance.ListField)
            {
                response += "\t" + item + Environment.NewLine;
            }
            return response;
        }
    }
}
