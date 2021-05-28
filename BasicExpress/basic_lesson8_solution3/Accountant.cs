using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_lesson8_solution3
{
    enum Post
    {
        Junior = 80,
        Middle = 120,
        Senoir = 160
    }
    class Accountant
    {
        Post worker;
        int hours;

        bool AskForBonus(Post worker, int hours)
        {
            if (hours > worker.GetHashCode())
                return true;
            else
                return false;
        }
    }
}
