using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using basic_lesson2_solution2.ConvertToo;

namespace basic_lesson2_solution2
{
    class Converter
    {


        public Converter(double usd, double eur, double rub) //переводит гривны
        {
            ConvertTo hryvniasTo = new ConvertTo();
            hryvniasTo.Dollar = 0.036 * usd;
            hryvniasTo.Euro = 0.030 * eur;
            hryvniasTo.Ruble = 2.68 * rub;
            Console.WriteLine("Перевод гривн в");
            Show(hryvniasTo);
            

            ConvertTo toHryvnias = new ConvertTo();
            toHryvnias.Dollar = 27.43 * usd;
            toHryvnias.Euro = 33.41 * eur;
            toHryvnias.Ruble = 0.37 * rub;
            Console.WriteLine("Перевод на гривны из");
            Show(toHryvnias);
        }

        public void Show(ConvertTo hryvnias)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Доллары - {hryvnias.Dollar}");
            Console.WriteLine($"Евро - {hryvnias.Euro}");
            Console.WriteLine($"Рубли - {hryvnias.Ruble}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
