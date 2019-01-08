using System;

namespace CatProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä on kissaohjelma!");

            Cat myCat = new Cat();
            Cat cat = new Cat(3);

            Console.WriteLine("Press any key to continue!");
            Console.ReadKey();
        }
    }
}