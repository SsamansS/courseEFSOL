using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

/*
 * Задание 4
Создайте приложение по шаблону Console Application. Создайте метод с названием ParseAsync, он
должен возвращать Task<IList<string>> и принимать строковой параметр с названием inputData. В теле
метода разбейте все содержимое строки inputData на отдельные слова по разделителям: пробел,
запятая, точка. Полученные слова запишите в строковой массив. Создайте коллекцию List<string>, в
которую запишите слова из массива без повторений. В методе Main считайте текст из файла или введите
несколько десятков слов через клавиатуру (на ваше усмотрение). Запишите это в строковую
переменную. Вызовите метод ParseAsync, куда передайте строковую переменную. Возвращаемое
значение метода в виде задачи запишите в переменную. Пока выполняется метод ParseAsync, сделайте
следующее:
 Выведите на экран консоли строку «Введите свое имя».
 Примите ввод данных пользователя с клавиатуры в строковую переменную name.
 Создайте экземпляр класса FileStream. На его основе создайте экземпляр класса StreamWriter
(НЕ ИСПОЛЬЗОВАТЬ АСИНХРОННЫЕ МЕТОДЫ ДЛЯ ЗАПИСИ В ФАЙЛ!).
На этом моменте вызовите ожидание завершения полученной задачи от вызова метода ParseAsync,
используя оператор await! Результат оператора await запишите в переменную с названием parseResult.
Запишите в файл первую строку: «{name} нашел {parseResult.Count} уникальных слов. Перечисление
слов: ». После, запишите через запятую (исключая последнее слово, там необходимо поставить точку)
все найденные слова методом ParseAsync.
*/

namespace AsyncP_lesson4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string PathFromFileForRead = @"C:\Users\User\Desktop\Новый текстовый документ.txt";
            FileStream FileForRead = File.Open(PathFromFileForRead, FileMode.Open);
            StreamReader streamReader = new StreamReader(FileForRead);
            string inputData = streamReader.ReadToEnd();

            var ParseTask =  ParseAsync(inputData);

            Console.WriteLine("Введите свое имя");
            string UserName = Console.ReadLine();

            string PathFromFileForWrite = @"C:\Users\User\Desktop\FileForWrite.txt";
            FileStream FileForWrite = File.Create(PathFromFileForWrite);
            StreamWriter streamWriter = new StreamWriter(FileForWrite);

            ParseTask.Wait();
            var parseResult = ParseTask.Result;

            streamWriter.WriteLine($"{UserName} нашел {parseResult.Count} уникальных слов. Перечисление слов: ");
            Console.WriteLine($"{UserName} нашел {parseResult.Count} уникальных слов. Перечисление слов: ");
            int i = 1;
            foreach(string word in parseResult)
            {
                streamWriter.WriteLine(i + ") " +  word);
                Console.WriteLine(i + ") " + word);
                ++i;
            }
        }
        static List<string> ParseMethod(object inputdata)
        {
            string inputData = Convert.ToString(inputdata);
            List<string> Words = new List<string>();

            string[] words = inputData.Split(new char[] { ' ', '.', ',', '\n', '!', '?' });

            foreach(string word in words)
            {
                if(!Words.Contains(word))
                {
                    Words.Add(word);
                }
            }

            return Words;
        }
        static async Task<IList<string>> ParseAsync(string inputData)
        {
            Task<IList<string>> taskWithListOfWords = new Task<IList<string>>(ParseMethod, inputData);
            taskWithListOfWords.Start();
            return await taskWithListOfWords;
        }
    }
}
