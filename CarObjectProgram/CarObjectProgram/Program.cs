using System;

namespace CarObjectProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            Car onlyCar = new Car("brand", 0);
            do
            {
                cki = UserInterface();
                Console.WriteLine();
                switch (cki.Key)
                {
                    case ConsoleKey.F1:
                        onlyCar.AskData();
                        break;
                    case ConsoleKey.F2:
                        onlyCar.ShowCarInfo();
                        break;
                    case ConsoleKey.F3:
                        onlyCar.Accelerate(UserAccelerate());
                        break;
                    case ConsoleKey.F4:
                        onlyCar.Brake();
                        break;
                    case ConsoleKey.Escape:
                        Console.WriteLine("Program closes now!");
                        break;
                    default:
                        Console.WriteLine("The unexpected happened!");
                        break;
                }
                Console.WriteLine("Press anykey!");
                Console.ReadKey();
                Console.Clear();   
            } while (cki.Key != ConsoleKey.Escape);

        }
        static ConsoleKeyInfo UserInterface()
        {
            Console.WriteLine("Choose what you want to do.");
            Console.WriteLine("[F1] Input car info.");
            Console.WriteLine("[F2] Print cars info.");
            Console.WriteLine("[F3] Accelerate car.");
            Console.WriteLine("[F4] Brake car.");
            Console.WriteLine("[Esc] Close program");

            return Console.ReadKey();
        }
        static int UserAccelerate()
        {
            bool isNumber;
            while (true)
            {
                Console.Write("Accelerate amount: ");
                isNumber = int.TryParse(Console.ReadLine(), out int accelerate);

                if (isNumber)
                {
                    return accelerate;
                }
                else
                {
                    Console.WriteLine("Input has to be number! Try again!");
                }
            }
        }
    }
}