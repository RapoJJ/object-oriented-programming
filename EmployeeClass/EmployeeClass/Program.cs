using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeClass
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Employee first = new Employee("Antti", "TJ", 4500, 1);
            Employee second = new Employee("Matti", "Tyäukko", 1800, 2);

            first.PrintEmployeeInfo();
            second.PrintEmployeeInfo();

            first.CompareSalary(second);*/

            /*Employee[] employees = new Employee[3];

            employees[0] = new Employee("Matti", "Team leader", 5000);
            employees[1] = new Employee("Tapio", "Programmer", 1600);
            employees[2] = new Employee("Jaakko", "Cleaner", 900);


            for (int i = 0; i < employees.Length; i++)
            {
                employees[i].PrintEmployeeInfo();
            }
            
            //employees[1].PrintEmployeeInfo();
            //employees[2].PrintEmployeeInfo();

            employees[0].CompareSalary(employees[1]);
            employees[0].CompareSalary(employees[2]);
            employees[1].CompareSalary(employees[2]);*/
             
            List<Employee> employeeList = new List<Employee>()
            {
                new Employee{name = "Matti", position ="Team leader", salary = 5000},
                new Employee{name = "Tapio", position ="Programmer", salary = 5},
                new Employee{name = "Jonne", position ="Cleaner", salary = 1900}
            };

            employeeList.ForEach(Console.WriteLine);

            Console.WriteLine("\nEmployeees sorted by salary!\n");

            employeeList.Sort((x, y) => x.salary - y.salary);
            employeeList.ForEach(Console.WriteLine);
        }
    }
}