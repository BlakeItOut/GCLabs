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
            Sheep blackie = new Sheep() { Name = "Blackie" };
            CountTestApp.RunTest(blackie, 2);
            Sheep dolly = (Sheep)blackie.Clone();
            dolly.Name = "Dolly";
            CountTestApp.RunTest(dolly, 3);
            CountTestApp.RunTest(blackie, 1);
            Console.ReadKey();
        }
    }
}
