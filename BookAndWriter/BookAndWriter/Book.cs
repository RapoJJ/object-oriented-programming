using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndWriter
{
    class Book
    {
        public string title;
        public string author;
        public string publisher;
        private double _price;
        public static string themeName;

        /// <summary>
        /// Nimi, Kirjailija, Kustantaja, Hinta, Teema
        /// </summary>
        public Book()
        {
            this.title = string.Empty;
            this.author = string.Empty;
            this.publisher = string.Empty;
            this._price = 0;
        }
        public Book(string title, string author, string publisher, double price, string theme)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.Price = price;
            themeName = theme;
        }
        public void BookInfoPrinter()
        {
            Console.WriteLine($"Book title: {this.title}" +
                $"Author: {this.author}\n" +
                $"Publisher: {this.publisher}\n" +
                $"Theme: {themeName}\n" +
                $"Price: {this.Price:N2} €.");
        }
        /// <summary>
        /// Checks if string name is the title of the book, if it is method prints books info.
        /// </summary>
        /// <param name="name"></param>
        public void FindBook(string name)
        {
            if (name == this.title)
            {
                Console.WriteLine($"Book {name} found!");
                Console.WriteLine($"Author: {this.author}\n" +
                    $"Publisher: {this.publisher}\n" +
                    $"Theme: {themeName}\n" +
                    $"Price: {this.Price:N2} €.");
            }
            else
            {
                Console.WriteLine($"Kirjan nimi ei ollut {name}.");
            }
            Console.WriteLine("");
        }
        /// <summary>
        /// Method sets static theme to user inputted one.
        /// </summary>
        public static void ChangeTheme()
        {
            Console.Write("Input new theme: ");
            themeName = Console.ReadLine();
        }
        /// <summary>
        /// Price property, gives 10% sale if books price is over 30.
        /// </summary>
        public double Price
        {
            get { return _price; }
            set
            {
                if (value > 30)
                {
                    _price = value * 0.9;
                }
                else
                {
                    _price = value;
                }
            }
        }
        /// <summary>
        /// Read only property of Author
        /// </summary>
        public string Author
        {
            get
            {
                return author;
            }
        }
    }
}