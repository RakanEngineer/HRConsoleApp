namespace HRConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter empolyee name");
            string name = Console.ReadLine();
            Console.WriteLine($"Welcome to HR System, {name}!");

            Console.WriteLine("Enter empolyee salary");
            decimal salary = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Your sallary is {salary:C}");
        }
    }
}
