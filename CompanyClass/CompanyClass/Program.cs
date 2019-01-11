using System;

namespace CompanyClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Company maestro = new Company("maestro", "lappee", "040", 500000, 450000);
            Company visma = new Company(maestro);

            visma.PrintInfo();
            maestro.PrintInfo();

            maestro.Profit();
            visma.Profit();
        }
    }
}
