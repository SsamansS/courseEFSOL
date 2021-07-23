using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_lesson12_solution4.Model
{
    public class Operations
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public double Plus()
        {
            return Number1 + Number2;
        }
        public double Minus()
        {
            return Number1 - Number2;
        }
        public double Mult()
        {
            return Number1 * Number2;
        }
        public double Div()
        {
            return Number1 / Number2;
        }
    }
}
