using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Movie
    {
        private string _title;
        public enum Categories
        {
            animated,
            drama,
            horror,
            scifi
        };
        private Categories _category;

        public Movie (string title, Categories category)
        {
            _title = title;
            _category = category;
        }
    }
}
