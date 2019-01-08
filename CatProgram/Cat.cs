using System;
using System.Collections.Generic;
using System.Text;

namespace CatProgram
{
    class Cat
    {
        public int weight;

        public Cat()
        {
            this.weight = 1;
            Console.WriteLine(this.weight);
        }
        public Cat(int weightValue)
        {
            this.weight = weightValue;
            Console.WriteLine(this.weight);
        }
    }
}