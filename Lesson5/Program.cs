using System;

namespace Lesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write anyone text");
            dynamic x = Console.ReadLine();
            int y = 0;
            Sum sum = new Sum();
            try
            {
                sum.Calculation(x, ref y);
            }
            catch(Exception e)
            {
                Console.WriteLine("Message: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
            }
            Console.WriteLine(y);
        }
    }
}