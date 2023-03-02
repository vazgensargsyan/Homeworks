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
                bool validName = human.Validation(name);
                bool validSurname = human.Validation(surname);
                if(!validName)
                {
                    throw new Exception(nameof(Errors.IncorrectName));
                }
                if(!validSurname)
                {
                    throw new Exception(nameof(Errors.IncorrectSurname));
                }
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
                Console.WriteLine("Anyway happy end");
            }

        }
    }
}