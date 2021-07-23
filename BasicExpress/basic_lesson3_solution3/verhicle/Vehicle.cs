using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using basic_lesson1_solution4;

namespace basic_lesson3_solution3
{
    class Vehicle
    {
        string _location;
        int _price;
        double _speed;
        public string _year_of_manufacture;

        public int price
        {
            get
            {
                    return _price;
            }
            set
            {
                _price = value;
            }
        }
        public double speed
        {
            get
            {
                    return _speed;
            }
            set
            {
                _speed = value;
            }
        }
        public string year_of_manufacture
        {
            get
            {
                if (_year_of_manufacture != null)
                    return _year_of_manufacture;
                else
                    return "надо ввести год";
            }
            set
            {
                _year_of_manufacture = value;
            }
        }
        public string location
        {
            get
            {
                if (_location != null)
                    return _location;
                else
                    return "надо ввести год";
            }
            set
            {
                _location = value;
            }
        }
    }
}
