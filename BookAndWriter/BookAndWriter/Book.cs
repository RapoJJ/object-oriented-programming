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
        /// Nimi, Kirjailija, Kustantaja, Hinta
        /// </summary>
        public Book()
        {
            this.title = string.Empty;
            this.author = string.Empty;
            this.publisher = string.Empty;
            this._price = 0;
        }
        public Book(string title, string author, string publisher, string theme)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this._price = 0;
            themeName = theme;
        }

        public void FindBook(string name)
        {
            if (name == this.title)
            {
                Console.WriteLine($"Book {name} found!");
                Console.WriteLine($"Author: {this.author}\n" +
                    $"Publisher: {this.publisher}\n" +
                    $"Theme: {themeName}\n" +
                    $"Price: {this._price}.");
            }
            else
            {
                Console.WriteLine($"Kirjan nimi ei ollut {name}.");
            }
            Console.WriteLine("");
        }
        public static void ChangeTheme()
        {
            Console.Write("Input new theme: ");
            themeName = Console.ReadLine();
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (value > 30)
                {
                    Console.WriteLine($"Books {this.title} price set to {value} and it's over 30 so it gets 10 % sale.");
                    _price = value * 0.9;
                }
                else
                {
                    Console.WriteLine($"Books {this.title} price set to {value} and it's under 30 so it stays the same.");
                    _price = value;
                }
            }
        }
    }
}