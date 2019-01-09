using System;

namespace BookProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Book firstBook = new Book("The Winds of Winter", "George R.R. Martin", "10101", 25);

            Console.WriteLine(firstBook.BookInfoPrinter());

            Book secondBook = new Book("Game of Thrones", "George R.R Martin", "10001", 10);
            Console.WriteLine(secondBook.BookInfoPrinter());

            Book thirdBook = new Book("The Lord of the Rings", "J.R.R. Tolkien", "12346", 15);
            Console.WriteLine(thirdBook.BookInfoPrinter());

            Console.WriteLine(firstBook.CompareBook(secondBook));
            Console.WriteLine(firstBook.CompareBook(thirdBook));
            Console.WriteLine(secondBook.CompareBook(thirdBook));
        }
    }
}
