using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETcore_lesson4_2
{
    public class Helper
    {
        public bool CheckOnContainsNums(string[] Parameters)
        {
            int curr = 0;
            foreach(string Parameter in Parameters)
            {
                if (Parameter == "" || Parameter == null)
                    return false;
                try
                {
                    Convert.ToInt32(Parameter);
                }
                catch
                {
                    ++curr;
                }
            }
            if (curr == Parameters.Length)
                return false;
            return true;
        }
    }
}
