using System;

namespace ProductRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string filePath = @"C:\temp\items.json";
            FileManager file = new FileManager(filePath);
            file.ReadWords();
            ConsoleKeyInfo cki;
            do
            {
                Console.WriteLine("Use normal numbers from keyboard to select options!");
                cki = UserInterface();
                Console.WriteLine();
                switch (cki.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine(file.ReadWords());
                        break;                   
                    case ConsoleKey.D2:
                        Console.WriteLine(file.FindProductsByCategory(InterfaceOption2()));
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine(file.FindProductsZeroStock());
                        break;
                    case ConsoleKey.D4:
                        Console.WriteLine(file.PrintIdAndName());
                        Console.WriteLine(file.FindProductById(UserInputInt()));
                        break;
                    case ConsoleKey.D5:
                        Console.WriteLine(file.PrintIdAndName());
                        file.AddComment(UserInputInt());
                        break;
                    case ConsoleKey.D6:
                        Console.WriteLine(file.PrintIdAndName());
                        file.DeleteComment(UserInputInt());
                        break;
                    case ConsoleKey.D7:
                        Console.WriteLine(file.PrintIdAndName());
                        file.UpdateAmount(UserInputInt());
                        break;
                    case ConsoleKey.Escape:
                        Console.WriteLine("Shutting down the program.");
                        break;
                    default:
                        Console.WriteLine("Wrong choice!");
                        break;
                }

                file.UpdateFile();
                Console.WriteLine("Press any key to continue!");
                Console.ReadKey();
                Console.Clear();
            } while (cki.Key != ConsoleKey.Escape);
        }

        private static ConsoleKeyInfo UserInterface()
        {
            Console.WriteLine("[1] Print all products.");
            Console.WriteLine("[2] Print all products from one category.");
            Console.WriteLine("[3] Print all products that are out of stock.");
            Console.WriteLine("[4] Choose product by Id and print out all of its info.");           
            Console.WriteLine("[5] Add comment to product.");
            Console.WriteLine("[6] Delete products comment.");
            Console.WriteLine("[7] Update products amount in stock and delete comment.");
            Console.WriteLine("[Esc] Exit");
            Console.Write("Press number key of your choice: ");
            return Console.ReadKey();
        }

        private static int UserInputInt()
        {
            while (true)
            {
                Console.Write("Input valid ID number: ");
                if (int.TryParse(Console.ReadLine(), out int input))
                {
                    return input;
                }

                Console.WriteLine("Input wasn't number!");
            }
        }

        private static int InterfaceOption2()
        {
            Console.WriteLine("Choose product category");
            Console.WriteLine("[1] Lajittelu ja säilytys");
            Console.WriteLine("[2] Paperit ja lehtiöt");
            Console.WriteLine("[3] Kynät");
            Console.WriteLine("[4] Kortit ja kirjekuoret");
            while (true)
            {
                Console.Write("Input number of product category you want to print: ");
                if (int.TryParse(Console.ReadLine(), out int input) && input < 5 && input > 0)
                {
                    return input;
                }

                Console.WriteLine("Input wasn't number from correct range (1 - 4). Try again!");
            }

        }
    }
}