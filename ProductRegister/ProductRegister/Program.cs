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
                cki = UserInterface();
                Console.WriteLine();
                switch (cki.Key)
                {
                    case ConsoleKey.P:
                        Console.WriteLine(file.ReadWords());
                        break;
                    case ConsoleKey.F:
                        Console.WriteLine(file.FindProduct(UserInputInt()));
                        break;
                    case ConsoleKey.A:
                        file.AddComment(UserInputString(), UserInputInt());
                        break;
                    case ConsoleKey.D:
                        file.DeleteComment(UserInputInt());
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

            //Console.WriteLine("PRINT UPDATED PRODUCT");

            //Console.WriteLine(file.FindProduct("110002"));

            //Console.WriteLine("UPDATE FILE AND PRINT IT");
        }

        private static ConsoleKeyInfo UserInterface()
        {
            Console.WriteLine("[P] Print all products");
            Console.WriteLine("[F] Find product based on ID number");
            Console.WriteLine("[A] Add comment to product");
            Console.WriteLine("[D] Delete products comment");
            Console.WriteLine("[Esc] Exit");
            Console.Write("Input choice: ");

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

        private static string UserInputString()
        {
            Console.Write("Input comment: ");
            return Console.ReadLine();
        }

    }
}