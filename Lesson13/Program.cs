using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace Lesson13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Film film = new Film();
            string yesOrNo = "Yes";
            while (yesOrNo == "Yes" || yesOrNo == "yes" || yesOrNo == "y")
            {
                Console.WriteLine("If you want see the film press Yes else press any key");
                yesOrNo = Console.ReadLine();
                if (yesOrNo == "Yes" || yesOrNo == "yes" || yesOrNo == "y")
                {
                    film.printGenres();
                    int genre_key = Int32.Parse(Console.ReadLine());
                    film.printFilms(genre_key);
                    int film_key = Int32.Parse(Console.ReadLine());
                    film.printGeneralInfo(film_key);
                    Console.WriteLine("Please rate on a of 1-5");
                    int rate = Int32.Parse(Console.ReadLine());
                }
            }
        }
    }
}