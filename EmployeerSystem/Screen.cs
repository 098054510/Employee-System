using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeerSystem
{
    class Screen
    {
        public static void MainScreen()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("-----Employee System-----");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Select Your Choice: ");
            Console.WriteLine("1 - Register a Employee.");
            Console.WriteLine("2 - Show All Registered Employees.");
            Console.WriteLine("3 - Exit.");
            Console.Write("Your Choice: ");
        }

        public static void Register()
        {
            Console.WriteLine("Insert The Employee Dates: ");
            Console.Write("Name: ");
            string Name = Console.ReadLine();
            Console.Write("Email: ");
            string Email = Console.ReadLine();
            Console.Write("Salary: ");
            double Salary = double.Parse(Console.ReadLine());
            Employee E = new Employee(Name, Email, Salary);
            Program.employees.Add(E);
        }

        public static void ShowEmployee()
        {
            Console.WriteLine(Program.employees);
            var Amount = 0;
            foreach (var employees in Program.employees)
            {
                Amount++;
                Console.WriteLine(Amount + " º" + employees);
            }
        }
    }
}
