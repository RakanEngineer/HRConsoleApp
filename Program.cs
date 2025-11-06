using HRConsoleApp.Abstractions;
using HRConsoleApp.Helpers;
using Microsoft.Win32;
using System.Collections;
using System.Collections.Generic;

namespace HRConsoleApp
{
    internal class Program
    {
        private static Payroll _payroll = new Payroll();
        //private static ConsoleUI _ui = new();
        private static IUI _ui = new ConsoleUI();
        static void Main(string[] args)
        {
            Console.WriteLine("HR Console Application");
            //Robot robot = new Robot("R2D2",45,25000);
            //string roboName = robot.GetName();
            //Console.WriteLine($"Robot Name: {roboName}\n");

            //robot.setName("Test");
            //robot.Age = -5;
            //Console.WriteLine($"Robot Name: {robot.GetName()}\n");

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

            Payroll payroll = new Payroll();
            //Employee emp = new Employee("Kalle",25000);

            SeedData();

            do
            {
                ShowMainMenu();
                string input = _ui.GetInput(); //Console.ReadLine() ?? string.Empty;

                switch (input)
                {
                    //case "1":
                    //    AddEmployee();
                    //    break;
                    //case "2":
                    //    PrintEmployees();
                    //    break;
                    //case "Q":
                    //    Environment.Exit(0);
                    //    break;
                    case MenuHelpers.Add:
                        AddEmployee();
                        break;
                    case MenuHelpers.Print:
                        PrintEmployees();
                        break;
                    case MenuHelpers.Quit:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
            while (true);
        }

        private static void AddEmployee()
        {
            //string empName;
            //bool success = false;

            //do
            //{
            //    Console.WriteLine("Enter employee name:");
            //    empName = Console.ReadLine() ?? string.Empty;
            //    if (string.IsNullOrWhiteSpace(empName))
            //    {
            //        Console.WriteLine("Employee name cannot be empty. Please try again.");
            //    }
            //    else
            //    {
            //        success = true;
            //    }
            //} while (!success);
            string empName = Util.AskForString("Name");
            uint empSalary = Util.AskForUInt("Salary");
            Console.WriteLine(empName, empSalary);

        }

        private static void PrintEmployees()
        {
            //List<Employee> employess = payroll.GetEmployees();
            IEnumerable<Employee> employess = _payroll.GetEmployees();

            foreach (Employee employee in employess)
            {
                //Console.WriteLine($"Name {employee.Name} Salary: {employee.Salary}");
                //Console.WriteLine(employee.Print());
                _ui.Print(employee.Print());
            }
        }




        //Dictionary<string, decimal> employees = new Dictionary<string, decimal>();
        //bool running = true;

        //while (running)
        //{
        //    Console.WriteLine("Choose the action you want to do:");
        //    Console.WriteLine("1. Add Employee");
        //    Console.WriteLine("2. View Employees");
        //    Console.WriteLine("3. Exit");

        //    string choice = Console.ReadLine();

        //    switch (choice)
        //    {
        //        case "1":
        //            Console.WriteLine("Enter empolyee name:");
        //            string name = Console.ReadLine();
        //            //Console.WriteLine($"Welcome to HR System, {name}!");

        //            Console.WriteLine("Enter empolyee salary:");
        //            decimal salary = Convert.ToDecimal(Console.ReadLine());
        //            //Console.WriteLine($"Your sallary is {salary:C}");

        //            employees[name] = salary;
        //            Console.WriteLine("Employee added successfully!\n");
        //            break;

        //        case "2":
        //            ViewEmployees(employees);
        //            break;
        //        case "3":
        //            running = false;
        //            Environment.Exit(0);
        //            break;
        //        default:
        //            Console.WriteLine("Invalid choice. Please try again.");
        //            break;
        //    }
        //}           

        //}
        private static void ShowMainMenu()
        {
            //Console.WriteLine($"1.Add {Environment.NewLine}2.Print {Environment.NewLine}Q.Exit");
            //Console.WriteLine($"{MenuHelpers.Add}.Add {Environment.NewLine}{MenuHelpers.Print}.Print {Environment.NewLine}{MenuHelpers.Quit}.Quit");
            _ui.Print($"{MenuHelpers.Add}.Add {Environment.NewLine}{MenuHelpers.Print}.Print {Environment.NewLine}{MenuHelpers.Quit}.Quit");
        }
        private static void SeedData()
        {
            _payroll.AddEmployee("Örjan", 30000);
            _payroll.AddEmployee("Anna", 35000);
            _payroll.AddEmployee("Kalle", 40000);
            _payroll.AddEmployee("Åsa", 45000);
            _payroll.AddEmployee("Åke", 50000);
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
