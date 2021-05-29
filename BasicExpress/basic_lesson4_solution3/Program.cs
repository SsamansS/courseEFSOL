using System;

namespace basic_lesson4_solution3
{
    /*
     * Задание 3
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Требуется:
    Создайте 2 интерфейса IPlayable и IRecodable. В каждом из интерфейсов создайте по 3 метода void
    Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop() соответственно.
    Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable.
    Написать программу, которая выполняет проигрывание и запись. 
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recordable");
            IRecodable recodable = new Player();
            recodable.Pause();
            recodable.Stop();
            recodable.Record();
            Console.WriteLine("\nPlayable");
            IPlayable playable = new Player();
            playable.Pause();
            playable.Stop();
            playable.Play();
            Console.WriteLine("Hello World!");
        }
    }
}
