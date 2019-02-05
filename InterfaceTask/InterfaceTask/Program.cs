using System;
using System.Collections.Generic;

namespace InterfaceTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            /*Product vasara = new Product("Vasara", 9.50, 5);
            Console.WriteLine($"Vasaroiden kokonaishinta: {vasara.CalculateTotal()}");
            Console.WriteLine(vasara.ToString());
            Console.WriteLine($"Löydettiin Vasara\n{vasara.GetProduct("Vasara")}");*/

            List<Product> productList = new List<Product>()
            {
                new Product("Vasara", 9.50, 5),
                new Product("Kirves", 17.00, 20),
                new Product("Mittanauha", 2.50, 40),
                new Product("Naula", 0.05, 1000),
            };

            productList.ForEach(Console.WriteLine);

            foreach(Product p in productList)
            {
                if (p.GetProduct("Vasara") != null)
                    Console.WriteLine($"Löydettiin Vasara\n{p}");
            }

            foreach (Product p in productList)
            {
                Console.WriteLine($"Tuotetta {p.name} on {p.amount} ja niiden kokonaishinta on {p.CalculateTotal():F2} €");
            }
        }
    }
}