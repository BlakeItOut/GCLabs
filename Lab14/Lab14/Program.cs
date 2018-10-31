using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count Alligators...");
            CountTestApp.RunTest(new Alligator(), 3);
            Console.WriteLine("\nCount Sheep...");
            CountTestApp.RunCloneTest();
            while (true)
            {
                string newName = Validator.promptUser("\nWhat would you like to name your clone? ", (str => !String.IsNullOrWhiteSpace(str)));
                int maxCount = int.Parse(Validator.promptUser("How many clones would you like? ", (num => int.TryParse(num, out maxCount) && maxCount > 0)));
                CountTestApp.RunTest((ICountable)(new Sheep()).Clone(), maxCount, newName);
                if (!Validator.promptYN("\nWould you like to clone another? (y/n) "))
                {
                    break;
                }
            } 
        }

    }
}
