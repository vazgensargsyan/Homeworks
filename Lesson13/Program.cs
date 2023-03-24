namespace Lesson13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If you want see the film press Yes else press No");
            string yesOrNo = Console.ReadLine();
            Film film = new Film();
            if (yesOrNo == "Yes" || yesOrNo == "yes")
            {
                film.printGenres();
                int genre_key = Int32.Parse(Console.ReadLine());
                film.printFilms(genre_key);
                int film_key = Int32.Parse(Console.ReadLine());
                film.printGeneralInfo(film_key);
            }
        }
    }
}