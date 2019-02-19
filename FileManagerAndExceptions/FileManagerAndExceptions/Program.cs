using System;
using System.Runtime.CompilerServices;

namespace FileManagerAndExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            var fPath = string.Empty;

            var file = new FileManager(fPath);
            Console.WriteLine(file.ReadWords());
            Console.WriteLine("----------------");

            var fileManager = new FileManager(@"C:/temp/testifile.txt");
            Console.WriteLine(fileManager.ReadWords());
        }
    }
}