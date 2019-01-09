using System;
using System.Collections.Generic;
using System.Text;

namespace BookProgram
{
    class Book
    {
        public string title;
        public string author;
        public string idNumber;
        public double price;

        public Book(string title, string author, string idNumber, double price)
        {
            this.title = title;
            this.author = author;
            this.idNumber = idNumber;
            this.price = price;
        }
        public string BookInfoPrinter()
        {
            return $"Nimi: {this.title}\nKirjailija: {this.author}\nId-tunnus: {this.idNumber}\nHinta: {this.price}\n";
        }
        public string CompareBook (Book book)
        {
            if (this.price > book.price)
                return $"{this.title} maksaa {this.price - book.price} euroa enemmän kuin {book.title}.";
            else
                return $"{book.title} maksaa {book.price - this.price} euroa enemmän kuin {this.title}.";
        }
    }
}