using System.Data;

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a math operation (not valid)");
            string x = Console.ReadLine();
            DataTable dt = new DataTable();
            Console.WriteLine(dt.Compute(x, ""));
        }
    }
}