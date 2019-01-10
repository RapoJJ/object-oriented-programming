using System;

namespace CarObjectProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Car firstCar = new Car();
            firstCar.AskData();
            firstCar.ShowCarInfo();

            Car secondCar = new Car();
            secondCar.AskData();
            secondCar.ShowCarInfo();

        }
    }
}
