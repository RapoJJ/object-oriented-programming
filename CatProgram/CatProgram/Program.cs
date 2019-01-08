using System;

namespace CatProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä on kissaohjelma!");

            Cat myFirstCat = new Cat("Nala", 1);


            myFirstCat.IncreaseWeight(5);
            myFirstCat.PrintWeight();

            Cat mySecondCat = new Cat("Olio", 3);
            mySecondCat.PrintWeight();
            
            Console.WriteLine("Press any key to continue!");
            Console.ReadKey();
        }
    }
}