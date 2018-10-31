using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    public class CountTestApp
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
        public static void RunCloneTest()
        {
            Sheep blackie = new Sheep() { Name = "Blackie" };
            RunTest(blackie, 2);
            Sheep dolly = (Sheep)blackie.Clone();
            dolly.Name = "Dolly";
            RunTest(dolly, 3);
            RunTest(blackie, 1);
        }
    }
}
