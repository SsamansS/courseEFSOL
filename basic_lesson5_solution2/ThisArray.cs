using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_lesson5_solution2
{
    class ThisArray
    {
        static int n;
        private int[] array = new int[3];

        public int[] Array { get => array; set => array = value; }

        //public ThisArray(int n)
        //{
        //    this.n = n;
        //}

        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public ThisArray(int nd)
        {
            //n = nd;
            Console.WriteLine(n);
        }
        public void Sortin()
        {
            //int[] arr = new int[];
            //arr = Array.Sort(array, 0, array.Length - 1);
            //foreach(int i in Array.Sort(array, 0, array.Length - 1))
        }
        public int Len()
        {
            return Array.Length;
        }

    }
}
