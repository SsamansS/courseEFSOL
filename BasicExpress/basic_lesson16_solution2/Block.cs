using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_lesson16_solution2
{
    class Block
    {
        public int index { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public double area { get; set; }
        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;
            return false;
        }
        public override string ToString()
        {
            return $@"{nameof(basic_lesson16_solution2)}.{nameof(Block)}
{nameof(index)} = {this.index}
{nameof(city)} = {this.city}
{nameof(country)} = {this.country}
{nameof(area)} = {this.area}";
        }
    }
}
