using System;

namespace BookAndWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Book firstBook = new Book("A Game of Thrones", "G. R.R. Martin", "Bantam Books", "Fantasy");

            Book secondBook = new Book("The Thirst", "Jo Nesbø", "Harvill Secker", "Crime");
        
            firstBook.FindBook("A Game of Thrones");
            firstBook.FindBook("Is it this one?");

            secondBook.FindBook("Guess?");
            secondBook.FindBook("The Thirst");


            Book.ChangeTheme();

            firstBook.Price = 40;
            secondBook.Price = 25;
            Console.WriteLine(firstBook.price);
            Console.WriteLine(secondBook.price);
        }
    }
}
