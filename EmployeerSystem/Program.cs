using System;
using System.Collections.Generic;

namespace EmployeerSystem
{
    class Program
    {

        public static List<Employee> employees = new List<Employee>();

        static void Main(string[] args)
        {
            Console.Clear();
            int option = 0;
            while (option == 0)
            {
                try
                {
                    Console.Clear();
                    Screen.MainScreen();
                    option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Screen.Register();
                            Console.WriteLine("Press 'Enter' to continue.");
                            try
                            {
                                option = int.Parse(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Unexpected Error " + e.Message);
                                option = 0;
                            }
                            break;
                        case 2:
                            Screen.ShowEmployee();
                            Console.WriteLine("Press 'Enter' to continue.");
                            try
                            {
                                option = int.Parse(Console.ReadLine());
                            }
                            catch(Exception e)
                            {
                                Console.WriteLine("Unexcepted Error " + e.Message);
                                option = 0;
                            }
                            break;
                        case 3:
                            Console.WriteLine("Ending...");
                            break;
                        default:
                            Console.WriteLine("Option not valid");
                            Console.WriteLine("Please insert a valid Option");
                            Console.WriteLine("Press 'ENTER' to Continue");
                            option = 0;
                            Console.ReadLine();
                            break;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Unexpected Error " + e.Message);
                    option = 0;
                    Console.ReadLine();
                }
            }
        }
    }
}
