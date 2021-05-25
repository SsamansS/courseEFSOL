using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_lesson5_solution2
{
    class ThisArray
    {
        //public static int n;
        int[] array;

        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
        public void Sortin()
        {
            //int[] arr = Array.Sort(array, 0, array.Length - 1);
            //foreach(int i in Array.Sort(array, 0, array.Length - 1))
        }

    }
}
