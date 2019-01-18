using System;

namespace TicketPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = UserAgeInput();
            
        }
   
        static int UserAgeInput()
        {
            while (true)
            {
                Console.Write("Input age: ");
                bool isNumber = int.TryParse(Console.ReadLine(), out int age);
                if (isNumber)
                {
                    return age;
                }
                else
                {
                    Console.WriteLine("Input wasnt number! Try again.");
                }
            }
        }
        static bool UserInfoInput(string question)
        {
            while (true)
            {
                Console.WriteLine(question + " ([1] = YES [2] = NO)");
                Console.Write("Input: ");
                bool isNumber = int.TryParse(Console.ReadLine(), out int answer);

                if (isNumber && answer == 1 || answer == 2)
                {
                    if (answer == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("Input wasnt [1] or [2]");
                }
            }
        }
    }
}