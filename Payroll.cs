
namespace HRConsoleApp
{
    internal class Payroll
    {
        private List<Employee> _employees;

        public Payroll()
        {
            _employees = new List<Employee>();
        }

        public void AddEmployee(string name, int salary)
        {
            Employee employee = new Employee(name, salary);
            _employees.Add(employee);
        }
    }
}