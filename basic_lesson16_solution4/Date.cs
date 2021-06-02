using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_lesson16_solution4
{
    enum Months
    {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        Septemer = 9,
        October = 10,
        November = 11,
        December = 12
    }
    class Date
    {
        byte _Day;
        byte _Month;

        public byte Day
        {
            get { return _Day; }
            set
            {
                if (value != 0)
                {
                    if (this._Month <= 7)
                    {
                        if (this.Year % 4 == 0 && this._Month == 2)
                        {
                            if (value <= 29)
                                _Day = value;
                        }
                        else if (this._Month == 2)
                        {
                            if (value <= 28)
                                _Day = value;
                        }
                        else if (this._Month % 2 != 0)
                        {
                            if (value <= 31)
                                _Day = value;
                        }
                        else
                        {
                            if (value <= 30)
                                _Day = value;
                        }
                    }
                    else
                    {
                        if (this._Month % 2 != 0)
                        {
                            if (value <= 30)
                                _Day = value;
                        }
                        else// if (this.Month % 2 == 0)
                        {
                            if (value <= 31)
                                _Day = value;
                        }

                    }
                }
            }
        }
        public byte Month
        {
            get { return _Month; }
            set
            {
                if (value <= 12 && value != 0)
                    _Month = value;
            }
        }
        public int Year { get; set; }





        public static int operator -(Date date1, Date date2)
        {
            int Days1 = date1.DaysInDate(date1);
            int Days2 = date2.DaysInDate(date2);
            return Days1 - Days2;
        }

        public static Date operator +(Date Date, int days)
        {
            if(days >= 0)
            {
                while(days >= 365)
                {
                    if (Date.Year % 4 == 0)
                    {
                        days -= 366;
                    }
                    else
                        days -= 365;
                    Date.Year++;
                }
                while(days >= 28)
                {
                    if (Date.Month <= 7)
                    {
                        if (Date.Year % 4 == 0 && Date.Month == 2)
                        {
                            days -= 29;
                        }
                        else if (Date.Month == 2)
                        {
                            days -= 28;
                        }
                        else if (Date.Month % 2 != 0)
                        {
                            days -= 31;
                        }
                        else
                        {
                            days -= 30;
                        }
                        Date.Month++;
                    }
                    else
                    {
                        if (Date.Month % 2 != 0)
                        {
                            days -= 30;
                        }
                        else
                        {
                            days -= 31;
                        }

                    }
                }
                Date.Day += (byte)days;
            }
            return Date;
        }











        int DaysInDate(Date date)
        {
            int Days = ((date.Year-1) / 4) * 366 + (date.Year -1 - (date.Year-1) / 4) * 365;
            Days += DaysInMonth(date);
            return Days;
        }
        int DaysInMonth(Date date)
        {
            int Days = date.Day;

            for (int i = 1; i < date.Month; i++)
            {
                if (date.Month <= 7)
                {
                    if (date.Year % 4 == 0 && i == 2)
                    {
                        Days += 29;
                    }
                    else if (i == 2)
                    {
                        Days += 28;
                    }
                    else if (i % 2 != 0)
                    {
                        Days += 31;
                    }
                    else
                    {
                        Days += 30;
                    }
                }
                else
                {
                    if (i % 2 != 0)
                    {
                        Days += 30;
                    }
                    else
                    {
                        Days += 31;
                    }

                }
            }
            return Days;
        }
    }
}
