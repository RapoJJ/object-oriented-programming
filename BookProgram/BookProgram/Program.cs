using System;

namespace BookProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Book firstBook = new Book("The Winds of Winter", "George R.R. Martin", "10101", 20);

            firstBook.BookInfoPrinter();

            Book secondBook = new Book("Game of Thrones", "George R.R Martin", "10001", 30);
            secondBook.BookInfoPrinter();
            Console.WriteLine(firstBook.CompareBook(secondBook));            
        }
    }
}
