using System;
    /*
     * Задание 2
    Используя Visual Studio, создайте проект по шаблону Console Application.
    Создайте класс CarCollection<T>. Реализуйте в простейшем приближении возможность
    использования его экземпляра для создания парка машин. Минимально требуемый интерфейс
    взаимодействия с экземпляром, должен включать метод добавления машин с названием машины и
    года ее выпуска, индексатор для получения значения элемента по указанному индексу и свойство
    только для чтения для получения общего количества элементов.
    Создайте метод удаления всех машин автопарка. 
    */


namespace basic_lesson11_solution2
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection<string> carCollection = new CarCollection<string>();
            //Car car = new Car();
            //car.name = "toyota";
            //car.year = 2121;

            carCollection.Add("noyosd");

            Console.WriteLine(carCollection[1]);
        }
    }
}
