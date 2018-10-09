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
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            while (true)
            {
                bool res = false;
                int entry = 0;
                Console.WriteLine("");
                while (entry < 1 || entry > 100 || !res)
                {
                    Console.Write("Enter an integer between 1 and 100: ");
                    res = int.TryParse(Console.ReadLine(), out entry);
                }
                Console.Write("For you, " + name + ": ");
                if (entry % 2 == 1)
                {
                    Console.WriteLine(entry + " Odd");
                }
                else if (entry <= 24)
                {
                    Console.WriteLine("Even and less than 25.");
                }
                else if (entry <= 60)
                {
                    Console.WriteLine("Even.");
                }
                else
                {
                    Console.WriteLine(entry + " Even.");
                }
                Console.Write("Would you like to continue?(y/n) ");
                if(Char.ToLower(Console.ReadKey().KeyChar) == 'n')
                {
                    break;
                }
            }
        }
    }
}
