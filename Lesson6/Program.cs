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

                bool nameValid = human.Validation(name);
                if (!nameValid)
                {
                    valid = false;
                    Console.WriteLine(Errors.IncorrectName);
                }

                bool surnameValid = human.Validation(surname);
                if (!surnameValid)
                {
                    valid = false;
                    Console.WriteLine(Errors.IncorrectSurname);
                }
                if (!valid)
                {
                    return;
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
                if (valid)
                {
                    Console.WriteLine("Happy end");
                }
                else
                {
                    Console.WriteLine("Not happy end");
                }
            }

        }
    }
}