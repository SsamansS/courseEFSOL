using System;
using System.IO;
using System.IO.Compression;
using System.Text;

/*
 * Задание 3
Напишите приложение для поиска заданного файла на диске. Добавьте код, использующий
класс FileStream и позволяющий просматривать файл в текстовом окне. В заключение
добавьте возможность сжатия найденного файла. 
*/

namespace prof_lesson3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь файла");
            string path = Console.ReadLine();// @"C:\Users\User\Desktop\Новая папка\Starter Express 1-4.txt";

            if(File.Exists(path))
            {
                FileStream file = File.OpenRead(path);
                StreamReader reader = new StreamReader(file);
                string s = File.ReadAllText(path, Encoding.Default);
                Console.WriteLine(s);

                Console.WriteLine("\nХотите ли вы архивировать этот файл?");
                if (Console.ReadLine() == "да")
                {
                    ZipCompression(file);
                    Console.WriteLine("Готово. Файл зархивирован в той же папке");
                }
                else
                    Console.WriteLine("Ок Ок");
            }
        }
        static void ZipCompression(FileStream sourse)
        {
            string zipPath = sourse.Name.Replace(sourse.Name[sourse.Name.LastIndexOf('.')..sourse.Name.Length], ".zip");
            FileStream destination = File.Create(zipPath);

            //создание компрессора
            GZipStream compressor = new GZipStream(destination, CompressionMode.Compress);

            //заполнение архива инфой из сайта
            int theByte = sourse.ReadByte();
            while(theByte != -1)
            {
                compressor.WriteByte((byte)theByte);
                theByte = sourse.ReadByte();
            }

            compressor.Close();

        }
    }
}
