using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTask
{
    class Product : ProductInterface
    {
        public string name;
        public double price;
        public int amount;

        public Product(string name, double price, int amount)
        {
            this.name = name;
            this.price = price;
            this.amount = amount;
        }

        public override string ToString()
        {
            return $"Name: {this.name}\tPrice: {this.price}\tAmount: {this.amount}";
        }

        public double CalculateTotal()
        {
            return this.amount * this.price;
        }
        public Object GetProduct(string name)
        {
            if (this.name == name)
                return this;
            else
                return null;
        }
    }
}
