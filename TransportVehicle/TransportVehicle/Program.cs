using System;

namespace TransportVehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(2.5, "S60", 5, "Sedan", "Volvo", 2004, 5400);
            car.PrintInfo();
            Console.WriteLine("-----------------------");

            Console.WriteLine("Printing cars override ToString.");
            Console.WriteLine(car.ToString());
            Console.WriteLine("-----------------------");

            Car copyCar = car;
            Console.WriteLine("Copy of 1st car");
            copyCar.PrintInfo();
            Console.WriteLine("-----------------------");

            Console.WriteLine("New car");
            Car newCar = new Car(2.0, "V70", 5, "Station Wagon", "Volvo", 2012, 14000);
            newCar.PrintInfo();
            Console.WriteLine("-----------------------");

            if (copyCar.Equals(car))
                Console.WriteLine("First car and copy car are the same.");
            else
                Console.WriteLine("First car and copy car aren't the same.");
            Console.WriteLine("-----------------------");

            if (copyCar.Equals(newCar))
                Console.WriteLine("First car and new car are the same.");
            else
            {
                Console.WriteLine("Firt car and new car aren't the same.");
            }
            Console.WriteLine("-----------------------");

            Truck truck = new Truck(12, "FM13", 2, "Truck", "Volvo", 2015, 20000, 30000, 10);
            Console.WriteLine("New Truck");
            truck.PrintInfo();
            Console.WriteLine("-----------------------");

            Console.WriteLine("Truck as car class.");
            Car test = (Car)truck;
            test.PrintInfo();
            Console.WriteLine("-----------------------");

            Console.Write("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
