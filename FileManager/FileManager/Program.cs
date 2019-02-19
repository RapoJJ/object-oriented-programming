using System;

namespace FileManager
{
    class Program
    {
        static void Main(string[] args)
        {
            FileManager file = new FileManager(@"C:\TEMP\refNumbers.txt");

            file.ReadWords();
        }
    }
}
