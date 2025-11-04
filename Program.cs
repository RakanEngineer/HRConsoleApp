using Microsoft.Win32;
using System.Collections;
using System.Collections.Generic;

namespace HRConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HR Console Application");
            Dictionary<string, decimal> employees = new Dictionary<string, decimal>();

            Console.WriteLine("Choose the action you want to do:");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. View Employees");
            Console.WriteLine("3. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter empolyee name");
                    string name = Console.ReadLine();
                    Console.WriteLine($"Welcome to HR System, {name}!");

                    Console.WriteLine("Enter empolyee salary");
                    decimal salary = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine($"Your sallary is {salary:C}");
                    
                    var employee = new Dictionary<string, decimal>
                    {
                        { name, salary }
                    };
                    break;
                
                case "2":
                    ViewEmployees(employees);
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            
        }

        private static void ViewEmployees(Dictionary<string, decimal> employees)
        {
            throw new NotImplementedException();
        }

       
    }
}
