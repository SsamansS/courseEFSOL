using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_lesson4_solution3
{
    public class Player : IRecodable, IPlayable
    {
        public void Record()
        {
            Console.WriteLine("запись");
        }
        public void Play()
        {
            Console.WriteLine("плэй");
        }
        public void Pause()
        {
            Console.WriteLine("пауза");
        }
        public void Stop() 
        {
            Console.WriteLine("стоп");
        }
    }
}
