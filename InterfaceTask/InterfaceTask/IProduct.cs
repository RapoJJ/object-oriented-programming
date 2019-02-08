using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTask
{
    interface IProduct
    {
        Object GetProduct(string name);
        double CalculateTotal();
    }
}
