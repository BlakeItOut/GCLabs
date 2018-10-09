using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int entry = 1;
            while (entry >= 1 && entry <= 100)
            {
                Console.Write("Enter an integer between 1 and 100:");
                entry = int.Parse(Console.ReadLine());
            }
            if (entry % 2 == 1)
            {
                Console.WriteLine(entry + " Odd");
            } else if (entry <= 24)
            {
                Console.WriteLine("Even and less than 25.");
            } else if (entry <= 60)
            {
                Console.WriteLine("Even.");
            } else
            {
                Console.WriteLine(entry + " Even.");
            }
            Console.ReadKey();
        }
    }
}
