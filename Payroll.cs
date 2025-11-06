
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
        public IEnumerable<Employee> GetEmployees() // Changed from List<Employee> to IEnumerable<Employee>
        {
            //ToDo: Fix this, not good // practice to return internal list
            //return _employees;
            return _employees.ToList();
        }
    }
}