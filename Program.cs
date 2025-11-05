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
            Robot robot = new Robot("R2D2",45,25000);
            string roboName = robot.GetName();
            Console.WriteLine($"Robot Name: {roboName}\n");

            robot.setName("Test");
            robot.Age = -5;
            Console.WriteLine($"Robot Name: {robot.GetName()}\n");

            //Robot r1 = new Robot("R1", 25, 25000);
            //Console.WriteLine(Robot.Count);
            //Robot r2 = new Robot("R2", 25, 25000);
            //Console.WriteLine(Robot.Count);
            //Robot r3 = new Robot("R3", 25, 25000);
            //Console.WriteLine(Robot.Count);
            //Robot r4 = new Robot("R4", 25, 25000);
            //Console.WriteLine(Robot.Count);
            //Robot r5 = new Robot("R5", 25, 25000);
            //Console.WriteLine(Robot.Count);

            Dictionary<string, decimal> employees = new Dictionary<string, decimal>();
            bool running = true;

            while (running)
            {
                Console.WriteLine("Choose the action you want to do:");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. View Employees");
                Console.WriteLine("3. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter empolyee name:");
                        string name = Console.ReadLine();
                        //Console.WriteLine($"Welcome to HR System, {name}!");

                        Console.WriteLine("Enter empolyee salary:");
                        decimal salary = Convert.ToDecimal(Console.ReadLine());
                        //Console.WriteLine($"Your sallary is {salary:C}");

                        employees[name] = salary;
                        Console.WriteLine("Employee added successfully!\n");
                        break;

                    case "2":
                        ViewEmployees(employees);
                        break;
                    case "3":
                        running = false;
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }           
            
        }

        private static void ViewEmployees(Dictionary<string, decimal> employees)
        {
            foreach (var e in employees)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("--------------------------\n");
        }

       
    }
}
