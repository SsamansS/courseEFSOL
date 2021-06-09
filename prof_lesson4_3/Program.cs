using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

/*
 * Задание 3
Напишите шуточную программу «Дешифратор», которая бы в текстовом файле могла бы
заменить все предлоги на слово «ГАВ!». 
*/

namespace prof_lesson4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] SplitChars = { ' ', ',', '.', '!', '?', '-' };
            string[] pril = { "for", "of" };

            string path = @"C:\Users\User\Desktop\Новый текстовый документ.txt";
            string[] s = File.ReadAllLines(path, Encoding.Default);
            string sad = File.ReadAllText(path, Encoding.Default);
            string[] asdas = sad.Split(SplitChars);
            //Console.WriteLine(asdas[12]);
            //Console.WriteLine(asdas[13]);
            //Console.WriteLine(asdas[14]);

            foreach (string line in s)
            {
                string[] words = line.Split(SplitChars);
            }


            Regex regex = new Regex(pril[1]);
            string pattern = @"\s[а-я]{1,3}\s";
            string result = string.Empty;
            result = Regex.Replace(sad, pattern, "ГАВ");


            string result1 = Regex.Replace("@_H e l l o-777.,:;ащк'!@#$%^&*()_-+<>?/",
                                  @"[^\w\.@-]", "ГАВ");


            //Regex regex = new Regex(pril[1]);
            Console.WriteLine(result);
            //foreach (string str in s)
            //{
            //    if (regex.IsMatch(str))
            //        Console.WriteLine("В исходной строке: \"{0}\" есть совпадения!", str);
            //}






            Console.WriteLine(result1);
        }
    }
}
