using basic_lesson1_solution3.book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_lesson1_solution3
{
    class Book
    {
        Title _title = null;
        Author _author = null;
        Content _content = null;

        void InitializBook()
        {
            this._title = new Title();
            this._author = new Author();
            this._content = new Content();
        }

        public Book(string title)
        {
            InitializBook();
            this._title.title = title;
        }

        public string author
        {
            set
            {
                this._author.author = value;
            }
        }

        public string content
        {
            set
            {
                this._content.content = value;
            }
        }

        public void Show()
        {
            this._title.Show();
            this._author.Show();
            this._content.Show();
        }
    }
}
