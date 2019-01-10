using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EmployeerSystem
{
    class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public Employee(string Name, string Email, double Salary)
        {
            this.Name = Name;
            this.Email = Email;
            this.Salary = Salary;
        }

        public override string ToString()
        {
            return "Name: " + Name + "\n"
                + "Email: " + Email + "\n"
                + "Salary: $" + Salary;
        }
    }
}
