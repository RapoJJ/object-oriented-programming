using System;

namespace TransportVehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("Truck", "Sisu", 1999, 200000);

            vehicle.PrintInfo();
            Console.WriteLine();

            Car car = new Car(2.5, "S60", 4, "Sedan", "Volvo", 2004, 5400);

            car.PrintInfo();

            Console.Write("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
