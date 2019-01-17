using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeClass
{
    class Employee
    {
        public string name;       
        public string position;
        
        public int id;
        public int salary;

        public Employee()
        {
            this.name = "name";
            this.position = "position";
            this.salary = 0;
            this.id = 0;
        }
        public Employee(string name, string position, int salary, int id)
        {
            this.name = name;
            this.position = position;
            this.salary = salary;
            this.id = id;
        }
        public void PrintEmployeeInfo()
        {
            Console.WriteLine($"Employee: {this.name}");
            Console.WriteLine($"Id: {this.id}");
            Console.WriteLine($"Position: {this.position}");
            Console.WriteLine($"Salary: {this.salary}");
            Console.WriteLine("-------------------------------");
        }
        public void CompareSalary(Employee employee)
        {
            Console.WriteLine($"{this.name} salary is {this.salary}. {employee.name} salary is {employee.salary}.");
            
            if (this.salary > employee.salary)
            {
                Console.WriteLine($"{this.name} gets paid more than {employee.name} by {this.salary - employee.salary}");
            }
            else if (this.salary == employee.salary)
            {
                Console.WriteLine($"{this.name} and {employee.name} have the same pay of {this.salary}");
            }
            else
            {
                Console.WriteLine($"{employee.name} gets paid more than {this.name} by {employee.salary - this.salary}");
            }

        }
    }
}
