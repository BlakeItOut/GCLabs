using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;
            bool validInt = false;
            char goOn;
            Random roll = new Random();

            Console.Write("Welcome to the Grand Circus Casino! Roll the dice? (y/n) ");
            goOn = Char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine("");
            if (goOn != 'n') {
                while (!validInt || goOn != 'n')
                {

                    Console.Write("How many sides should each die have? ");
                    validInt = int.TryParse(Console.ReadLine(), out userInput);
                    if (validInt)
                    {
                        goOn = rollDice(userInput, roll);
                        Console.WriteLine("");
                    }
                }
            }
        }

        static char rollDice (int sides, Random roll)
        {
            int rollCount = 1;
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Roll " + rollCount++ + ":");
                int[] rolls = getDiceRoll(sides, roll);
                Console.WriteLine(rolls[0]);
                Console.WriteLine(rolls[1]);
                Console.WriteLine(results(rolls));
                Console.WriteLine("");
                Console.Write("Roll again? (y/n) ");
                if (Char.ToLower(Console.ReadKey().KeyChar) == 'n')
                {
                    Console.WriteLine("");
                    break;
                }
            }
            Console.Write("Would you like to continue? (y/n) ");
            return Char.ToLower(Console.ReadKey().KeyChar);
            
        }

        static int[] getDiceRoll(int sides, Random roll)
        {
            int[] rolls = new int[]
                {roll.Next(1, sides+1), roll.Next(1, sides+1)};
            return rolls;
        }

        static string results(int[] rolls)
        {
            if (rolls[0] == 1 && rolls[1] == 1)
            {
                return ("Snake eyes");
            }
            else if (rolls[0] == 6 && rolls[1] == 6)
            {
                return ("Box Cars");
            }
            else if ((rolls[0] + rolls[1]) == 7 || (rolls[0] + rolls[1]) == 11)
            {
                return ("Craps");
            } else
            {
                return ("Goose egg");
            }
        }
    }
}
