using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Learn your squares and cubes!");
                Console.WriteLine("");
                Console.Write("Enter an integer: ");
                int upTo = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Number     Squared    Cubed");
                Console.WriteLine("======     =======    =====");
                for (int i = 1; i <= upTo; i++)
                {
                    int square = i * i;
                    int cube = square * i;
                    Console.WriteLine("{0,-11:0}{1,-11:0}{2,-11:0}", i, square, cube);
                }
                Console.Write("Continue? (y/n):");
                if (Char.ToLower(Console.ReadKey().KeyChar) == 'n')
                {
                    break;
                }
                Console.WriteLine("");
            }
        }
    }
}
