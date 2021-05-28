using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_lesson1_solution3.book
{
    class Content
    {
        string _content;
        public string content
        {
            get
            {
                if (_content != null)
                    return _content;
                else
                    return "Надо ввести текст";
            }
            set
            {
                _content = value;
            }
        }
        public void Show()
        {
            Console.WriteLine("Отрывок:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
