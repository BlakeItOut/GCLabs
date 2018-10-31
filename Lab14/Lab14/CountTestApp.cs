using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class CountTestApp
    {
        public static void RunTest(ICountable c, int MaxCount)
        {
            CountUtil.Count(c, MaxCount);
        }
        public static void RunTest(ICountable c, int MaxCount, string newName)
        {
            ((Sheep)c).Name = newName;
            CountUtil.Count(c, MaxCount);
        }
    }
}
