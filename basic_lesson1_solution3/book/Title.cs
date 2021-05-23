using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_lesson1_solution3.book
{
    class Title
    {
        string _title;
        public string title
        {
            get
            {
                if (_title != null)
                    return _title;
                else
                    return "Надо ввести название книги";
            }
            set
            {
                _title = value;
            }
        }
        public void Show()
        {
            Console.Write("Название книги: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(title + "\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
