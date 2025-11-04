namespace HRConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter empolyee name");
            string name = Console.ReadLine();
            Console.WriteLine($"Welcome to HR System, {name}!");
        }
    }
}
