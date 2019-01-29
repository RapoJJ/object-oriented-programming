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

            Console.WriteLine();
            Console.WriteLine(car.ToString());


            Car newCar = new Car(2.5, "S60", 4, "Sedan", "Volvo", 2004, 5400);

            Car newestCar = new Car(2.0, "S49", 4, "Sedan", "Volvo", 2008, 14000);

            /*if (newCar.Equals(car))
                Console.WriteLine("On samat");
            else
                Console.WriteLine("Ei ole");

            if (newCar.Equals(newestCar))
                Console.WriteLine("Ei ole samat");
            else
            {
                Console.WriteLine("Ei ole");
            }*/

            Console.Write("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
