using System;
using Literature;

namespace BookAndWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Book firstBook = new Book("A Game of Thrones", "G. R.R. Martin", "Bantam Books", 35, "Fantasy");

            Book secondBook = new Book("The Thirst", "Jo Nesbø", "Harvill Secker", 25,"Crime");
        
            firstBook.FindBook("A Game of Thrones");
            firstBook.FindBook("Is it this one?");

            secondBook.FindBook("Guess?");
            secondBook.FindBook("The Thirst");


            Book.ChangeTheme();


            Console.WriteLine($"{firstBook.title} author is {firstBook.Author}.\n");
            Console.WriteLine($"{secondBook.title} author is {secondBook.Author}.\n");

            Author author = new Author
            {
                Name = "G. R.R. Martin",
                Birthday = "September 20, 1948",
                Book = firstBook
            };
            Console.WriteLine("\nPrint Authors info and his books info:");
            author.PrintInfo();

        }
    }
}
