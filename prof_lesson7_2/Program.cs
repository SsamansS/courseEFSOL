using System;

    /*
     * Задание 2
    Создайте класс и примените к его методам атрибут Obsolete сначала в форме, просто
    выводящей предупреждение, а затем в форме, препятствующей компиляции.
    Продемонстрируйте работу атрибута на примере вызова данных методов. 
    */

namespace prof_lesson7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeMethods methods = new SomeMethods();
            methods.Method1();
            //methods.Method2();
        }
    }
    class SomeMethods
    {
        [Obsolete("ошибка")]
        public void Method1()
        {
            Console.WriteLine("done Method1");
        }
        [Obsolete("ошибка - компиляция запрещена", true)]
        public void Method2()
        {
            Console.WriteLine("done Method2");
        }
    }
}
