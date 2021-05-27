using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_lesson9_solution3
{
    static class MethodsFor
    {
        public delegate int MyDelegate();
        public delegate int ArrayDelegates(MyDelegate[] myDelegates);
        static public int Method()
        {
            Random random = new Random();
            return random.Next(1, 21);
        }
        static public MyDelegate[] Arrayka()
        {
            MyDelegate myDelegate = new MyDelegate(MethodsFor.Method);
            MyDelegate[] mies = new MyDelegate[3] { myDelegate, myDelegate, myDelegate };
            return mies;
            //foreach(MyDelegate item in mies)
            //{
            //    item = myDelegate;//new MyDelegate(MethodsFor.Method);
            //}
        }

    }
}
