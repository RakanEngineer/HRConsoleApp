
namespace HRConsoleApp
{
    
    public class Robot
    {
        private string _name;
        private int _age;

        public int Age 
        { 
            get {return _age; }

            set
            {
                if (value < 0)
                {
                    _age = 0;
                }
                else
                {
                    _age = value;
                }
            }
        }
        public static int Count { get; set; }
        public static int Salary { get; }

        public void SetSalary(int salary)
        {
           // Salary = salary;
        }

        public Robot(string name, int age, int salary)
        {
            _name = name;
            Age = age;
            //Salary = salary;
        }

        public string GetName()
        {
            return _name;
        }

        public void setName(string name)
        {
            _name = name;
        }
    }
}