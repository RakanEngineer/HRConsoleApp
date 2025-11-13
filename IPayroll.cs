using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRConsoleApp
{
    internal interface IPayroll
    {
        void AddEmployee(string name, uint salary);
        IEnumerable<Employee> GetEmployees();
    }
}
