using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    enum Categories
    {
        animated = 1,
        drama = 2,
        horror = 3,
        scifi = 4
    };
    class Program
    {
        static void Main(string[] args)
        {
            MovieList movieListClass = new MovieList();
            Console.WriteLine("Welcome to the Movie List Application!\n\nThere are over 100 movies in this list!");
            while(true)
            {
                Categories category = (Categories)Enum.Parse(typeof(Categories), Validator.promptUser("What category are you interested in?\n1=Animated\n2=Drama\n3=Horror\n4=Science Fiction\n", (str => Enum.TryParse(str, out category))));
                Console.WriteLine("");
                foreach (Movie movie in movieListClass.getMovieList(category.ToString()))
                {
                    Console.WriteLine($"{movie.GetTitle()} from {movie.GetYear()}");
                }
                Console.WriteLine("");
                if (Validator.promptContinue())
                {
                    break;
                }
                Console.Clear();
            }
        }
    }
}
