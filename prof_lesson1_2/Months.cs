using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prof_lesson1_2.Mon
{
    class Months
    {
        string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        int[] DaysInAMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        public string GetMonth(int num)
        {
            string response = "dont have";
            if (num == months.Length)
                return months[^1];
            for(int i = 0; i < months.Length; i++)
            {
                if (i == num)
                    return response = months[i];
            }
            return response;
        }

        public List<string> SearchMonths(int days)
        {
            List<string> mons = new List<string>();
            if (days == 28 || days == 29)
            {
                mons.Add("February");
                return mons;
            }
            for (int i = 0; i < DaysInAMonth.Length; i++)
            {
                if (DaysInAMonth[i] == days)
                    mons.Add(months[i]);
            }
            return mons;
        }
    }
}
