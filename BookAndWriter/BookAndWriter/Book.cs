using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndWriter
{
    class Book
    {           //nimi, kirjailija, kustantaja, hinta sekä teemanNimi
        public string title;
        public string author;
        public string publisher;
        public double price;
        public static string themeName;

        /// <summary>
        /// Nimi, Kirjailija, Kustantaja, Hinta
        /// </summary>
        public Book()
        {
            this.title = string.Empty;
            this.author = string.Empty;
            this.publisher = string.Empty;
            this.price = 0;
        }
        public Book(string title, string author, string publisher, double price, string theme)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.price = price;
            themeName = theme;
        }

        public void FindBook(string name)
        {
            if (name == this.title)
            {
                Console.WriteLine($"Title: {this.title}\n" +
                    $"Author: {this.author}\n" +
                    $"Publisher: {this.publisher}\n" +
                    $"Theme: {this.ThemeName}" +
                    $"Price: {this.price}.");
            }
        }
        public string ThemeName
        {
            get { return themeName; }
            set { themeName = value; }
        }

    }
}
