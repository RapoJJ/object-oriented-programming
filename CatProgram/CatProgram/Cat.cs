using System;
using System.Collections.Generic;
using System.Text;

namespace CatProgram
{
    class Cat
    {
        public string name;
        public int weight;

        public Cat()
        {
            this.weight = 1;
            //Console.WriteLine($"Kissan paino on {this.weight}.");
        }
        public Cat(string name, int weightValue)
        {
            this.name = name;
            this.weight = weightValue;
            Console.WriteLine($"Luotu kissa {this.name}, jonka paino on {this.weight}");
        }
        public Cat(int weightValue)
        {
            this.weight = weightValue;
            //Console.WriteLine($"Kissan paino on {this.weight}.");
        }
        public void IncreaseWeight(int value)
        {
            this.weight += value;
            Console.WriteLine($"Kissan {this.name} uusi paino on {this.weight}.");
        }
        public void PrintWeight()
        {
            Console.WriteLine($"Kissan {this.name} paino on {this.weight}.");
        }
    }
}