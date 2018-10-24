using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab11
{
    public class CompareMovies : IComparer
    {
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
