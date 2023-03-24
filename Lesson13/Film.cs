using System.Collections;

namespace Lesson13
{
    internal class Film : IDataStructur
    {
        public Dictionary<int, string> categories { get; set; }
        public Dictionary<int, string> genres { get; set; }
        public Hashtable filmToGenre { get; set; }
        public Hashtable filmToPrice { get; set; }
        public Dictionary<int, string> films { get; set; }
        public List<int> watchList = new List<int>();
        public List<int> rate = new List<int>();
        public Film()
        {
            setValue();
        }
        public void printGenres()
        {
            Console.WriteLine("Please choose a genre");
            foreach (var genre_key in genres.Keys)
            {
                Console.WriteLine("For {0} press {1}", genres[genre_key], genre_key);
            }
        }
        public void printFilms(int genre_key)
        {
            Console.WriteLine("Please choose a film");
            foreach (var film_key in filmToGenre.Keys)
            {
                if ((int)filmToGenre[film_key] == genre_key)
                {
                    Console.WriteLine("For watch {0} press {1} paid = {2}$", film_key, films.FirstOrDefault(x => x.Value == film_key).Key, filmToPrice[film_key]);
                }
            }
        }

        public void printGeneralInfo(int film_key)
        {
            if (films.ContainsKey(film_key))
            {
                Console.WriteLine("count 1 ---> " + watchList.Count());
                Console.WriteLine("You are watch {0} film, it's {1} genre and it's costs {2}$.", films[film_key], genres[(int)filmToGenre[films[film_key]]], filmToPrice[films[film_key]]);
                watchList.Add(film_key);
                Console.WriteLine(watchList);
                Console.WriteLine("count 2 ---> " + watchList.Count());
            }
            else
            {
                Console.WriteLine("That film are not in our list");
            }
        }

        public void setValue()
        {
            Dictionary<int, string> categories = new Dictionary<int, string>();
            categories.Add(1, "Free");
            categories.Add(2, "Paid");
            this.categories = categories;

            Dictionary<int, string> genres = new Dictionary<int, string>();
            genres.Add(1, "Horror");
            genres.Add(2, "Thriller");
            genres.Add(3, "Western");
            genres.Add(4, "Romance");
            this.genres = genres;

            Dictionary<int, string> films = new Dictionary<int, string>();
            films.Add(1, "Scream");
            films.Add(2, "Old");
            films.Add(3, "Ma");
            films.Add(4, "Pathaan");
            films.Add(5, "Fall");
            films.Add(6, "Infinite");
            films.Add(7, "Sunset");
            films.Add(8, "Vampires");
            films.Add(9, "Australia");
            films.Add(10, "Blonde");
            films.Add(11, "Holidate");
            films.Add(12, "Focus");
            this.films = films;

            Hashtable filmToGenre = new Hashtable();
            filmToGenre.Add("Scream", 1);
            filmToGenre.Add("Old", 1);
            filmToGenre.Add("Ma", 1);
            filmToGenre.Add("Pathaan", 2);
            filmToGenre.Add("Fall", 2);
            filmToGenre.Add("Infinite", 2);
            filmToGenre.Add("Sunset", 3);
            filmToGenre.Add("Vampires", 3);
            filmToGenre.Add("Australia", 3);
            filmToGenre.Add("Blonde", 4);
            filmToGenre.Add("Holidate", 4);
            filmToGenre.Add("Focus", 4);
            this.filmToGenre = filmToGenre;

            Hashtable filmToPrice = new Hashtable();
            filmToPrice.Add("Scream", 13.5d);
            filmToPrice.Add("Old", 0);
            filmToPrice.Add("Ma", 0);
            filmToPrice.Add("Pathaan", 22d);
            filmToPrice.Add("Fall", 0);
            filmToPrice.Add("Infinite", 35.5);
            filmToPrice.Add("Sunset", 0);
            filmToPrice.Add("Vampires", 0);
            filmToPrice.Add("Australia", 0);
            filmToPrice.Add("Blonde", 100);
            filmToPrice.Add("Holidate", 0);
            filmToPrice.Add("Focus", 0);
            this.filmToPrice = filmToPrice;
        }
    }
}
