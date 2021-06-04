using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_lesson11_solution2
{
    class Car
    {
        string _name;
        int _year;
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int year
        {
            get { return _year; }
            set { _year = value; }
        }
        public Car(string Name, int Year)
        {
            this._name = Name;
            this._year = Year;
        }
    }
}
