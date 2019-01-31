using System;

namespace TransportVehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehicle vehicle = new Vehicle("Truck", "Sisu", 1999, 200000);

            //vehicle.PrintInfo();

            Car car = new Car(2.5, "S60", 5, "Sedan", "Volvo", 2004, 5400);

            car.PrintInfo();

            Console.WriteLine("Printing cars override ToString.");
            Console.WriteLine(car.ToString());


            Car newCar = new Car(2.5, "S60", 5, "Sedan", "Volvo", 2004, 5400);

            Car newestCar = new Car(2.0, "V70", 5, "Station Wagon", "Volvo", 2012, 14000);

            Console.WriteLine("Copy of 1st cat");
            newCar.PrintInfo();
            
            Console.WriteLine("New car");
            newestCar.PrintInfo();
            
            if (newCar.Equals(car))
                Console.WriteLine("Cars are same.");
            else
                Console.WriteLine("Cars aren't same.");

            if (newCar.Equals(newestCar))
                Console.WriteLine("Cars are same.");
            else
            {
                Console.WriteLine("Cars aren't same.");
            }


            Truck truck = new Truck(12, "FM13", 2, "Truck", "Volvo", 2015, 20000, 30000, 10);

            truck.PrintInfo();

            Car test = (Car)truck;

            test.PrintInfo();

            Console.Write("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
