using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
            Console.WriteLine("");
            while (true)
            {
                double length = errorHandling("Length");
                double width = errorHandling("Width");
                Console.WriteLine("Area:" + (width * length).ToString());
                Console.WriteLine("Perimeter:" + ((width + length) * 2).ToString());
                Console.WriteLine("");
                Console.Write("Continue?(y/n):");
                char response = Console.ReadKey().KeyChar;
                if (response == 'n')
                {
                    break;
                }
                Console.WriteLine("");
                Console.WriteLine("");
            }
        }

        static double errorHandling(string entry)
        {
            double doubledEntry;
            while (true)
            {
                try
                {
                    Console.Write("Enter " + entry + ":");
                    doubledEntry = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            }
            return doubledEntry;

        }
    }
}
