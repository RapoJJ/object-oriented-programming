using System;
using System.Collections.Generic;
using System.Text;

namespace CarObjectProgram
{
    class Car
    {
        public string brand;
        public int speed;

        public Car (string brand, int speed)
        {
            this.brand = brand;
            this.speed = speed;
        }
        public void AskData()
        {
            Console.Write("Brand name: ");
            this.brand = Console.ReadLine();
            Console.Write("Speed: ");
            string speedValue = Console.ReadLine();
            bool isNumberC = int.TryParse(speedValue, out int speed);
            if (isNumberC)
            {
                this.speed = speed;
            }
            else
            {
                Console.WriteLine("Input wasnt number or it was empty, speed of car is 0.");
                this.speed = 0;
            }
        }
        public void ShowCarInfo()
        {
            Console.WriteLine($"Brand {this.brand} has speed of {this.speed}.");
        }
        public void Accelerate(int speedIncrease)
        {
            if (speedIncrease > 0)
            {
                this.speed += speedIncrease;
                Console.WriteLine($"Car {this.brand} used ACCELERATE! New speed is {this.speed}.");
            }
            else if (speedIncrease == 0)
            {
                Console.WriteLine($"Car {this.brand} didn't use ACCELERATE! Speed is still {this.speed}.");
            }
            else
            {
                Console.WriteLine("Negative using ACCELERATE isn't possible!");
            }
        }
        public void Brake()
        {
            this.speed = this.speed * 9 / 10;
            Console.WriteLine($"Car {this.brand} used BRAKE! The new speed is {this.speed}.");
        }
    }
}