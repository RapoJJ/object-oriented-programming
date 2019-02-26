using System;

namespace ProductRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\temp\items.json";
            ConsoleKeyInfo cki;


            FileManager file = new FileManager(filePath);

            Console.WriteLine(file.ReadWords());


            Console.WriteLine(file.FindProduct("110001"));


            file.AddComment("Tilattu 300", "110002");


            Console.WriteLine("PRINT UPDATED LIST");

            Console.WriteLine(file.FindProduct("110002"));
        }

        static ConsoleKeyInfo UserInterface()
        {
            Console.WriteLine("[A] Tulosta kaikki tuotteet.");
            Console.WriteLine("[B] Tulosta valitsemasi tuotteen kaikki tiedot");
            Console.WriteLine("[C] Lisää/poista kommentti tuotteeseen");
            Console.WriteLine("[Esc] Sulje ohjelma.");
            Console.Write("Syötä valinta: ");

            return Console.ReadKey();
        }
    }
}