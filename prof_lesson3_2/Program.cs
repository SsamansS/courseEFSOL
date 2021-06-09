using System;
using System.IO;
using System.Text;

/*
 * Задание 2 
Создайте файл, запишите в него произвольные данные и закройте файл. Затем снова откройте
этот файл, прочитайте из него данные и выведете их на консоль.
*/

namespace prof_lesson3_2
{
    class Program
    {

        static void Main(string[] args)
        {
            string path = @"D:\Test.txt";
            File.Create(path).Close();
            File.WriteAllText(path, "dfddsfsdftgrhytrhytrhrtlg" +
                "dfdfdfds");

            Console.ReadKey();

            string s = File.ReadAllText(path, Encoding.Default);
            Console.WriteLine(s);
        }
    }
}
