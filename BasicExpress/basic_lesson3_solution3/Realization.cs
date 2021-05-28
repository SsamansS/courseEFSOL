using basic_lesson3_solution3.KindOfVehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_lesson3_solution3
{
    class Realization:Vehicle
    {
        Car car;
        Plane plane;
        Ship ship;

        void Initsialization()
        {
            this.car = new Car();
            this.plane = new Plane();
            this.ship = new Ship();
        }

        public void Show()
        {
            Initsialization();
            car.Show();
            plane.Show();
            ship.Show();
        }
    }
}
