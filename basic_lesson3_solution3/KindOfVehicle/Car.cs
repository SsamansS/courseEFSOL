using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_lesson3_solution3.KindOfVehicle
{
    class Car:Vehicle
    {
        void Iinit()
        {
            this.location = "Россия";
            this.price = 1234;
            this.speed = 80;
            this.year_of_manufacture = "2021";
        }
        public void Show()
        {
            Iinit();
            Console.WriteLine(@$"
        {nameof(Car)}
{nameof(this.location)}: {location}
{nameof(this.price)}: {price}
{nameof(this.speed)}: {speed}
{nameof(this.year_of_manufacture)}: {year_of_manufacture}
");
        }
    }
}
