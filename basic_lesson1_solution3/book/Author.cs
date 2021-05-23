using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_lesson1_solution3.book
{
    class Author
    {
        string _author;
        public string author
        {
            get
            {
                if (_author != null)
                    return _author;
                else
                    return "Надо ввести название книги";
            }
            set
            {
                _author = value;
            }
        }
        public void Show()
        {
            Console.Write("Автор книги: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(author + "\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
