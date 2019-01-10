using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;

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
            Console.WriteLine("3 - Custom Search.");
            Console.WriteLine("4 - Exit.");
            Console.Write("Your Choice: ");
        }

        public static void Register()
        {
            Console.WriteLine("Insert The Employee Dates: ");
            Console.Write("Name: ");
            string Name = Console.ReadLine();
            Console.Write("Email: ");
            string Email = Console.ReadLine();
            Console.Write("Salary: $");
            double Salary = double.Parse(Console.ReadLine());
            Employee E = new Employee(Name, Email, Salary);
            Program.employees.Add(E);
        }

        public static void ShowEmployee()
        {
            var Amount = 0;
            foreach (var employees in Program.employees)
            {
                Amount++;
                Console.WriteLine(Amount + " º" + employees);
            }
        }

        public static void Search()
        {
            Console.WriteLine("1 - Search For People Whose salary is more than $2000.");
            Console.WriteLine("2 - Search For name.");
            int N = int.Parse(Console.ReadLine());
            if (N == 1)
            {
                var e1 = from e in Program.employees
                         where e.Salary > 2000.0
                         select e;
            }
            else
            {
                Console.Write("Insert The Name of Employee: ");
                string N = Console.ReadLine();
                var e2 = from e in Program.employees
                         where e.Name = N
                         select e;
            }
        }
    }
}
