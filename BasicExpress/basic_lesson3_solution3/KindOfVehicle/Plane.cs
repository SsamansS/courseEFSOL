using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_lesson3_solution3.KindOfVehicle
{
    class Plane:Vehicle
    {
        double hight = 17.34;
        int quantityOfPassanger = 34;
        void Iinit()
        {
            this.location = "Гондурас";
            this.price = 123456;
            this.speed = 1;
            this.year_of_manufacture = "2000";
        }
        public void Show()
        {
            Iinit();
            Console.WriteLine(@$"
        {nameof(Plane)}
{nameof(this.location)}: {location}
{nameof(this.price)}: {price}
{nameof(this.speed)}: {speed}
{nameof(this.year_of_manufacture)}: {year_of_manufacture}
{nameof(hight)}: {hight}
{nameof(quantityOfPassanger)}: {quantityOfPassanger}
");
        }
    }
}
