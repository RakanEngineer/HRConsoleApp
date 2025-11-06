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
        public string Print()
        {
            return $"Name {Name} Salary: {Salary}";
        }

        //public override string ToString()
        //{
        //    return $"Name {Name} Salary: {Salary}";
        //}
    }
}