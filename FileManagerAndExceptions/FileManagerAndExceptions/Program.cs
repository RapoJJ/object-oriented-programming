using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace FileManagerAndExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            var fPath = string.Empty;
            Console.WriteLine("Trying to read file which doesn't exist");
            var file = new FileManager(fPath);
            Console.WriteLine(file.ReadWords());
            Console.WriteLine("----------------");

            Console.WriteLine("Reading .txt file");
            var fileManager = new FileManager(@"C:\temp\testifile.txt");
            Console.WriteLine(fileManager.ReadWords());
            Console.WriteLine("-----------------");

            Console.WriteLine("Reading movies.json file");
            var fileManagerJson = new FileManager(@"C:\temp\movies.json");
            fileManagerJson.LoadJson();
            Console.WriteLine("---------------");

            Console.WriteLine("Trying to read file which doesn't exist");
            var fileManagerJsonTest = new FileManager(String.Empty);
            fileManagerJsonTest.LoadJson();
        }
    }
}