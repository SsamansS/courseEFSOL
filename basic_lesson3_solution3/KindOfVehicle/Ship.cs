using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_lesson3_solution3.KindOfVehicle
{
    class Ship:Vehicle
    {
        int PessengerCount = 42;
        string PortOfRegistration = "порт DISCARD";
        void Iinit()
        {
            this.location = "Мадагаскар";
            this.price = 12345678;
            this.speed = 23.45;
            this.year_of_manufacture = "1991";
        }
        public void Show()
        {
            Iinit();
            Console.WriteLine(@$"
        {nameof(Ship)}
{nameof(this.location)}: {location}
{nameof(this.price)}: {price}
{nameof(this.speed)}: {speed}
{nameof(this.year_of_manufacture)}: {year_of_manufacture}
{nameof(PessengerCount)}: {PessengerCount}
{nameof(PortOfRegistration)}: {PortOfRegistration}
");
        }
    }
}
