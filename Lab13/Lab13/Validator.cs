using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Validator
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

        public static bool promptYN(string message)
        {
            return promptUser(message, (response => response.ToLower()[0] == 'y' || response.ToLower()[0] == 'n')).ToLower()[0] == 'y';
        }
    }
}
