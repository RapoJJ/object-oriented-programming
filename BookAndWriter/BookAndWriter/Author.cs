using System;
using System.Collections.Generic;
using System.Text;
using Literature;

namespace BookAndWriter
{
    class Author
    {
        private string _name;
        private string _birthday;
        public Book _book;

        public Author()
        {
            this._name = string.Empty;
            this._birthday = string.Empty;
            this._book = new Book();
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }
        public Book Book
        {
            get { return _book; }
            set { _book = value; }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Authors name: {this.Name}\n" +
                $"Authors birthday: {this.Birthday}");
            this.Book.BookInfoPrinter();
        }
    }
}