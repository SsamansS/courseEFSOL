using System;
using System.IO;
using System.Threading;

namespace prof_lesson11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"D:\C# EFSOL\CourseFromEFSOL\courseEFSOL\prof_lesson11_2\TextFile1.txt";
            string path2 = @"D:\C# EFSOL\CourseFromEFSOL\courseEFSOL\prof_lesson11_2\TextFile2.txt";

            Thread[] threads = { new Thread(() => WriteTextFileInOtherFile(path1)), new Thread(() => WriteTextFileInOtherFile(path2)) };
            foreach(var thread in threads)
            {
                thread.Start();
                thread.Join();
            }
        }
        static void WriteTextFileInOtherFile(string pathFromFileToRead)
        {
            string AllText = File.ReadAllText(pathFromFileToRead);
            var thread = new Thread(() => WriteTextInFile(AllText));
            thread.Start();
            thread.Join();
        }
        static void WriteTextInFile(string AllTextFromFile)
        {
            File.AppendAllText(@"D:\C# EFSOL\CourseFromEFSOL\courseEFSOL\prof_lesson11_2\TextFile3.txt", AllTextFromFile);
        }
    }
}
