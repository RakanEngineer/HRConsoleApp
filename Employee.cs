namespace HRConsoleApp
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        public Employee(string name, int salary)
        {
            this.Name = name;
            Salary = salary;
        }
    }
}