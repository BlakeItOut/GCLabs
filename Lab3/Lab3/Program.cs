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
            var name = Console.ReadLine();
            while (true)
            {
                var isInt = false;
                var entry = 0;
                Console.WriteLine("");
                while (entry < 1 || entry > 100 || !isInt)
                {
                    Console.Write("Enter an integer between 1 and 100: ");
                    isInt = int.TryParse(Console.ReadLine(), out entry);
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
            Console.WriteLine("");
            Console.Write("Well, " + name + ", it's been positively real all the way to 100!");
            Console.ReadKey();
        }
    }
}
