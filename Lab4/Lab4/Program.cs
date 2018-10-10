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
            Console.WriteLine("Learn your squares, cubes, and more!");
            Console.WriteLine("");
            while (true)
            {
                Console.Write("What mode would you like to enter? (n=normal, s=super, q=quit)");
                Char mode = Char.ToLower(Console.ReadKey().KeyChar);
                if (mode == 'n')
                {
                    Console.WriteLine("");
                    while (true)
                    {
                        Console.Write("Enter an integer: ");
                        int upTo = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("Number     Squared    Cubed");
                        Console.WriteLine("======     =======    =====");
                        for (int i = 1; i <= upTo; i++)
                        {
                            Console.WriteLine("{0,-11:0}{1,-11:0}{2,-11:0}", i, i * i, i * i * i);
                        }
                        Console.Write("Continue? (y/n):");
                        if (Char.ToLower(Console.ReadKey().KeyChar) == 'n')
                        {
                            Console.WriteLine("");
                            break;
                        }
                        Console.WriteLine("");
                    }
                }
                else if (mode == 's')
                {
                    Console.WriteLine("");
                    while (true)
                    {
                        Console.Write("Enter an integer or enter m to return to menu: ");
                        string entry = Console.ReadLine();
                        if (entry.ToLower() == "m")
                        {
                            break;
                        }
                        int upTo = int.Parse(entry);
                        Console.WriteLine("");
                        for (int j = 1; j <= upTo; j++)
                        {
                            Console.Write("{0,-11:0}", "^" + j);
                        }
                        Console.WriteLine("");
                        for (int j = 1; j <= upTo; j++)
                        {
                            Console.Write("{0,-11:0}", "=====");
                        }
                        Console.WriteLine("");
                        for (int i = 1; i <= upTo; i++)
                        {
                            for (int j = 1; j <= upTo; j++)
                            {
                                Console.Write("{0,-11:0}", Math.Pow(i, j));
                            }
                            Console.WriteLine("");
                        }
                        Console.WriteLine("");
                    }
                } else if (mode == 'q')
                {
                    break;
                } else
                {
                    Console.WriteLine();
                    continue;
                }
            }
        }
    }
}
