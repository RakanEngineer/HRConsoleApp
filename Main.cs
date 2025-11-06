using HRConsoleApp.Abstractions;
using HRConsoleApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRConsoleApp
{
    internal class Main
    {
        private IUI _ui;
        private Payroll _payroll;

        public Main(IUI ui, Payroll payroll)
        {
            _ui = ui;
            _payroll = payroll;
        }

        public void Run()
        {
            SeedData();
            do
            {
                ShowMainMenu();
                string input = _ui.GetInput();

                switch (input)
                {
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

        private void AddEmployee()
        {
            string name = Util.AskForString("Name");
            uint salary = Util.AskForUInt("Salary");
            _payroll.AddEmployee(name, salary);

        }

        private void PrintEmployees()
        {
            IEnumerable<Employee> employees = _payroll.GetEmployees();

            //employees[0].Name = "Sten-Ove"; 
            foreach (Employee employee in employees)
            {
                _ui.Print(employee.Print());
            }
        }

        private void ShowMainMenu()
        {
            _ui.Print($"{MenuHelpers.Add}.Add {Environment.NewLine}{MenuHelpers.Print}.Print {Environment.NewLine}{MenuHelpers.Quit}.Quit");
        }

        private void SeedData()
        {
            _payroll.AddEmployee("Örjan", 30000);
            _payroll.AddEmployee("Anna", 35000);
            _payroll.AddEmployee("Kalle", 40000);
            _payroll.AddEmployee("Åsa", 45000);
            _payroll.AddEmployee("Åke", 50000);
        }

    }
}