using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movieList = new List<Movie>
            {
                new Movie("Star Wars", Movie.Categories.scifi),
            };
        }
    }
}
