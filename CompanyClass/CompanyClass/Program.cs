using System;

namespace CompanyClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Company washers = new Company("Pyykkääjät", "Pyykkikatu 5", "0503123211", 500000, 487000);
            Company software = new Company("Koodaajat Oy", "Koodikatu 10", "0401231231", 5000000, 305000);
            Company painters = new Company("Maalaajat", "Maalitie 25", "0401112223", 1000000, 300000);
            Company copyCats = new Company(painters);

            washers.PrintInfo();
            software.PrintInfo();
            painters.PrintInfo();
            copyCats.PrintInfo();

            washers.Profit();
            software.Profit();
            painters.Profit();
            copyCats.Profit();
        }
    }
}
