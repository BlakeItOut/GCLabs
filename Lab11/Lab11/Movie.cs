using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    public class Movie : IComparable, IComparer
    {
        private string _title;
        private string _category;
        private int _releaseYear;

        public Movie (string title = null, int releaseYear = 0, string category = null)
        {
            _title = title;
            _category = category;
            _releaseYear = releaseYear;
        }

        public string GetCategory () => _category;

        public string GetTitle() => _title;

        public int GetYear() => _releaseYear;

        public int CompareTo(object that)
        {
            Movie thatMovie = (Movie)that;
            int result = this._title.CompareTo(thatMovie._title);
            if (result == 0)
            {
                result = this._releaseYear.CompareTo(thatMovie._releaseYear);
            }
            return result;
        }

        public int Compare(object x, object y)
        {
            Movie thisMovie = (Movie)x;
            Movie thatMovie = (Movie)y;
            int result = ((new CaseInsensitiveComparer()).Compare(thisMovie.GetTitle(), thatMovie.GetTitle()));
            if (result == 0)
            {
                result = ((new CaseInsensitiveComparer()).Compare(thisMovie.GetYear(), thatMovie.GetYear()));
                if (result == 0)
                {
                    result = ((new CaseInsensitiveComparer()).Compare(thisMovie.GetCategory(), thatMovie.GetCategory()));
                }
            }
            return result;

        }
    }
}
