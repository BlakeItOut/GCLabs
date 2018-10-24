using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    public class Validator
    {
        public static string promptUser(string message, Func<string, bool> condition)
        {
            Console.Write(message);
            string textValue = Console.ReadLine();
            if (condition(textValue))
            {
                return textValue;
            }
            else
            {
                Console.WriteLine("This is not a valid input.");
                return promptUser(message, condition);
            }
        }

        public static string promptUser(string message, Func<string, bool> condition, string response)
        {
            Console.Write(message);
            string textValue = response;
            if (condition(textValue))
            {
                return textValue;
            }
            else
            {
                Console.WriteLine("This is not a valid input.");
                return promptUser(message, condition);
            }
        }

        public static bool promptContinue()
        {
            return promptUser("Continue? (y/n) ", (response => response.ToLower()[0] == 'y' || response.ToLower()[0] == 'n')).ToLower()[0] == 'n';
        }

        public static bool promptContinue(string textValue)
        {
            return promptUser("Continue? (y/n) ", (response => response.ToLower()[0] == 'y' || response.ToLower()[0] == 'n'), textValue).ToLower()[0] == 'n';
        }
    }
}
