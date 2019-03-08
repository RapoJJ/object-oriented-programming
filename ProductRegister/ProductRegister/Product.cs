using System;
using System.Collections.Generic;
using System.Text;

namespace ProductRegister
{
    class Product
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string GroupName { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public string Comment { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} Id: {Id} Group Name: {GroupName} Price: {Price:F2} €";
        }
    }
}