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
            Console.WriteLine($"Kirjan nimi: {this.title}");
            Console.WriteLine($"Kirjan kirjailija: {this.author}");
            Console.WriteLine($"Kirjan id-tunnus: {this.idNumber}");
            Console.WriteLine($"Kirjan hinta: {this.price}");
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
