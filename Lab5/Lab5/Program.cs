using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            long userInput = 0;
            bool validInt = false;
            char goOn = 'y';

            while (!validInt || goOn != 'n')
            {
                Console.Write("Enter an integer between 1 and 25:");
                validInt = long.TryParse(Console.ReadLine(), out userInput);
                if (validInt && userInput >= 1 && userInput <= 25)
                {
                    Console.WriteLine(calculateFactorial(userInput));
                    Console.Write("Would you like to continue?");
                    goOn = Char.ToLower(Console.ReadKey().KeyChar);
                    Console.WriteLine("");
                }
            }
        }

        static long calculateFactorial(long x)
        {
            if (x == 1)
            {
                return x;
            } else
            {
                return x*calculateFactorial(x - 1);
            }
        }
    }
}
