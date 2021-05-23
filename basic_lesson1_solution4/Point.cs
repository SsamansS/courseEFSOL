using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_lesson1_solution4
{
    class Point
    {
        private int _x;
        private int _y;
        private string _name;

        public int x
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        public int y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
    }
}
