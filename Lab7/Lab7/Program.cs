using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a valid name: ");
            string name = Console.ReadLine();
            Console.WriteLine(checkName(name));
            Console.WriteLine("");
            Console.Write("Please enter a valid email: ");
            string email = Console.ReadLine();
            Console.WriteLine(checkEmail(email));
            Console.WriteLine("");
            Console.Write("Please enter a valid phone number (###-###-####): ");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine(checkPhoneNumber(phoneNumber));
            Console.WriteLine("");
            Console.Write("Please enter a valid date (MM/DD/YYYY): ");
            string date = Console.ReadLine();
            Console.WriteLine(checkDate(date));
            Console.WriteLine("");
            Console.Write("Please enter a valid HTML element: ");
            string HTML = Console.ReadLine();
            Console.WriteLine(checkHTML(HTML));
            Console.WriteLine("");
            Console.ReadKey();
        }

        static string getMessage(string type, bool valid)
        {
            return valid ? ("The " + type + " is valid!") : ("Sorry, the " + type + " is not valid!");
        }

        static string checkName(string userInput)
        {
            Regex namey = new Regex(@"^[A-Z][a-z]{0,29}$");
            return getMessage("name", namey.IsMatch(userInput));
        }

        static string checkEmail(string userInput)
        {
            Regex emailey = new Regex(@"[A-Za-z0-9]{5,30}@[A-Za-z0-9]{5,10}\.[A-Za-z0-9]{2,3}");
            return getMessage("email", emailey.IsMatch(userInput));
        }

        static string checkPhoneNumber(string userInput)
        {
            return getMessage("phone number", Regex.IsMatch(userInput, @"[0-9]{3}-[0-9]{3}-[0-9]{4}"));
        }

        static string checkDate(string userInput)
        {
            return getMessage("date", Regex.IsMatch(userInput, @"[0-1][1-9]/[0-3][0-9]/[0-2][0-9]{3}"));
        }

        static string checkHTML(string userInput)
        {
            return getMessage("HTML", Regex.IsMatch(userInput, @"<[a-z0-9]{1,2}>.*<\/[a-z0-9]{1,2}>"));
        }
    }
}
