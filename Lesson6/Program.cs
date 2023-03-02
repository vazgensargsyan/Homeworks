using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Transactions;

namespace Registration
{
    internal class Program
    {
        static bool valid = true;
        enum Errors
        {
            IncorrectName,
            IncorrectSurname
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();
                Console.Write("Enter your surname: ");
                string surname = Console.ReadLine();
                Human human = new Human();
                human.Validation(name);
                human.Validation(surname);
                Console.Write("Enter anyone char: ");
                char myChar = Char.Parse(Console.ReadLine());
                byte count = human.CheckCount(myChar, name + surname);
                Console.WriteLine("There are {0} {1} in the phrase", count, myChar);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Amen depqum Happy end");
            }

        }
    }
}