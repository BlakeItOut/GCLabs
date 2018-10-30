using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Program
    {
        public static List<Player[]> _winnersLosers = new List<Player[]>();
        public static List<Roshambo.Roshambos> _userChoices = new List<Roshambo.Roshambos>();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock Paper Scissors!");

            Player user = new Player1() { Name = Validator.promptUser("\nEnter your name: ", (name => !String.IsNullOrWhiteSpace(name))) };
            Player opponent = getOpponent();
            
            while (true)
            {
                user.Roshambo = translateStringToRoshambos(Validator.promptUser("\nRock, paper, or scissors? (r/p/s) ", (name => name.Equals("r", StringComparison.OrdinalIgnoreCase) || name.Equals("p", StringComparison.OrdinalIgnoreCase) || name.Equals("s", StringComparison.OrdinalIgnoreCase))).ToLower());
                Console.WriteLine($"\n{user.Name}: {user.Roshambo}\n{opponent.Name}: {opponent.GenerateRoshambo()}");
                _userChoices.Add(user.Roshambo);
                _winnersLosers.Add(getWinnerLoser(user, opponent));
                Console.WriteLine(_winnersLosers[_winnersLosers.Count-1]==null?"Draw!":$"{_winnersLosers[_winnersLosers.Count - 1][0].Name} wins");
                if (!(Validator.promptYN("\nPlay again? (y/n) ")))
                {
                    break;
                }
            }
            int wins = _winnersLosers.Where(match => match != null && match[0].Name == user.Name).Count();
            int draws = _winnersLosers.Where(match => match == null).Count();
            int loses = _winnersLosers.Count() - wins - draws;
            Console.WriteLine($"Wins: {wins}, Draws: {draws}, Loses {loses}");
            Console.ReadKey();
        }

        static Player getOpponent ()
        {
            switch (Validator.promptUser("\nWould you like to play against TheJets or TheSharks of TheFuzz (j/s/f)? ", (name => name.Equals("j", StringComparison.OrdinalIgnoreCase) || name.Equals("s", StringComparison.OrdinalIgnoreCase) || name.Equals("f", StringComparison.OrdinalIgnoreCase))).ToLower())
            {
                case "j":
                    return new Player1();
                case "s":
                    return new Player2();
                case "f":
                    return new Player3();
                default:
                    return getOpponent();
            }  
        }

        static Roshambo.Roshambos translateStringToRoshambos (string userInput)
        {
            string choices = "rps";
            return (Roshambo.Roshambos)choices.IndexOf(userInput);
        }

        static Player[] getWinnerLoser (Player user, Player opponent)
        {
            switch (((int)user.Roshambo-(int)opponent.Roshambo+3)%3)
            {
                case 1:
                    return new Player[] { user, opponent };
                case 2:
                    return new Player[] { opponent, user };
                default:
                    return null;
            }
        }
    }
}
