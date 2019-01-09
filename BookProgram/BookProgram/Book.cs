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
        public int price;

        public Book(string title, string author, string idNumber, int price)
        {
            this.title = title;
            this.author = author;
            this.idNumber = idNumber;
            this.price = price;
        }
        public Book (string title)
        {
            this.title = title;
        }

        public void BookInfoPrinter()
        {
            Console.Write("Kirjan tiedot: ");
            Console.Write($" Nimi: {this.title}");
            Console.Write($" Kirjailija: {this.author}");
            Console.Write($" Id-tunnus: {this.idNumber}");
            Console.Write($" Hinta: {this.price}\n");
        }
        public string CompareBook (Book book)
        {
            if (this.price > book.price)
                return $"{this.title} on kalliimpi kuin {book.title}.";
            else
                return $"{book.title} on kalliimpi kuin {this.title}.";
        }
    }
}
