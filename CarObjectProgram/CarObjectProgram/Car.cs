using System;
using System.Collections.Generic;
using System.Text;

namespace CarObjectProgram
{
    class Car
    {
        public string brand;
        public int speed;

        public void AskData()
        {
            Console.Write("Syötä auton merkki: ");
            this.brand = Console.ReadLine();
            Console.Write("Syötä auton nopeus: ");
            this.speed = int.Parse(Console.ReadLine());
        }
        public void ShowCarInfo()
        {
            Console.WriteLine($"Auton {this.brand} nopeus on {this.speed}.");
        }

        public void Accelerate(int speedIncrease)
        {
            this.speed += speedIncrease;
        }
    }
}