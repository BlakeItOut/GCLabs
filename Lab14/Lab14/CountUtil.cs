using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    public class CountUtil
    {
        public static void Count(ICountable c, int MaxCount)
        {
            Console.WriteLine("");
            for (; c.GetCount() <= MaxCount; c.IncrementCount())
            {
                Console.WriteLine(c.ToString());
            }
            c.ResetCount();
        }
    }
}
