using System;

namespace TicketPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Customer newCustomer = new Customer();
            Ticket newTicket = new Ticket();

            double price;

            while (newCustomer.age == -1)
            {
                newCustomer.Age = UserAgeInput();
            }

            price = newTicket.TicketCalculator(newCustomer);

            if (!newTicket.isTicketPrice)
            {
                UserInfoInput(newCustomer);
                price = newTicket.TicketCalculator(newCustomer);
            }

            Console.WriteLine($"Ticket price is {price:N2} €.");
            Console.WriteLine("Press anykey to close.");
            Console.ReadKey();
        }
        /// <summary>
        /// Asks user to input age. If age is not number format asks again. Returns int.
        /// </summary>
        /// <returns></returns>
        static int UserAgeInput()
        {
            while (true)
            {
                Console.Write("Input age: ");
                if (int.TryParse(Console.ReadLine(), out int age))
                {
                    return age;
                }
                else
                {
                    Console.WriteLine("Input wasnt number! Try again.");
                }
            }
        }
        /// <summary>
        /// Builds UserInterface with different ticket types. Returns ConsoleKeyInfo.
        /// </summary>
        /// <returns></returns>
        static ConsoleKeyInfo UserInterface()
        {
            Console.WriteLine("Choose correct ticket type by inputting corresponding key.");
            Console.WriteLine("[F1] Mtk member.");
            Console.WriteLine("[F2] Student.");
            Console.WriteLine("[F3] Student and MTK member.");
            Console.WriteLine("[F4] Conscript.");
            Console.Write("[F5] Normal ticket.");
            return Console.ReadKey();
        }
        /// <summary>
        /// Asks user to input type of ticket he wants. Sets customer info according to type of ticket user chose.
        /// </summary>
        /// <param name="customer"></param>
        static void UserInfoInput(Customer customer)
        {
            bool isKey = false;
            ConsoleKeyInfo cki;
            do
            {
                cki = UserInterface();
                
                switch (cki.Key)
                {
                    case ConsoleKey.F1:
                        customer.MtkMember = true;
                        isKey = true;
                        break;
                    case ConsoleKey.F2:
                        customer.Student = true;
                        isKey = true;
                        break;
                    case ConsoleKey.F3:
                        customer.Student = true;
                        customer.MtkMember = true;
                        isKey = true;
                        break;
                    case ConsoleKey.F4:
                        customer.Conscript = true;
                        isKey = true;
                        break;
                    case ConsoleKey.F5:
                        isKey = true;
                        break;
                    default:
                        Console.WriteLine("You didnt press correct key!");
                        break;
                }
                Console.WriteLine("");
            } while (!isKey);
        }       
    }
}