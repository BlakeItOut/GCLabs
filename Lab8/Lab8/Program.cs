using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to our C# class. Which student would you like to learn more about? (enter a number 1-15): ");
            while (true)
            {
                try
                {
                    int studentNum = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    string[] studentDetails = getStudent(studentNum);
                    Console.Write($"Student {studentNum} is {studentDetails[0]}. What would you like to know about {studentDetails[0].Split(' ')[0]}? (enter \"hometown\" or \"favorite food\"): ");
                    getDetailChoice:
                    string detail = Console.ReadLine().ToLower();
                    Console.WriteLine("");
                    if (detail != "hometown" && detail != "favorite food")
                    {
                        Console.Write("That data does not exist. Please try again. (enter \"hometown\" or \"favorite food\"): ");
                        goto getDetailChoice;
                    }
                    else if (detail == "hometown")
                    {
                        Console.Write($"{studentDetails[0].Split(' ')[0]} is from {studentDetails[1]}. Would you like to know more? (enter \"yes\" or \"no\"): ");
                    }
                    else if (detail == "favorite food")
                    {
                        Console.Write($"{studentDetails[0].Split(' ')[0]} likes {studentDetails[2]}. Would you like to know more? (enter \"yes\" or \"no\"): ");
                    }
                    getContinueChoice:
                    string knowMore = Console.ReadLine().ToLower();
                    Console.WriteLine("");
                    if (knowMore == "no")
                    {
                        break;
                    }
                    else if (knowMore == "yes")
                    {
                        Console.Write("Which other student would you like to learn more about? (enter a number 1-15): ");
                        continue;
                    }
                    else
                    {
                        Console.Write("That is not a valid response. Please try again. (enter \"yes\" or \"no\"): ");
                        goto getContinueChoice;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Write("That student does not exist. Press any key to see a directory or enter \"skip\" to skip: ");
                    if (Console.ReadLine() != "skip")
                    {
                        displayStudentDirectory();
                    }
                    Console.WriteLine("");
                    Console.Write("Which student would you like to learn more about? (enter a number 1-15): ");
                }
                catch (FormatException)
                {
                    Console.WriteLine("");
                    Console.Write("That is not a whole number. Please try again. (enter a number 1-15): ");
                }
            }
            Console.Write("Thanks");
            Console.ReadKey();
        }
        
        static string [] getStudent(int studentNum)
        {
            string[][] studentArray = {
                new string [] {"Michael Hern", "Canton, MI","Chicken Wings"},
                new string [] {"Taylor Everts", "Caro, MI", "Cordon Bleu"},
                new string [] {"Joshua Zimmerman", "Taylor, MI", "Turkey"},
                new string [] {"Lin-Z Chang", "Toledo, OH", "Ice Cream"},
                new string [] {"Madelyn Hilty", "Oxford, MI", "Croissent"},
                new string [] {"Nana Banahene", "Guana", "Empanadas"},
                new string [] {"Rochelle Toles", "Mars", "Space Cheese"},
                new string [] {"Shah Shahid", "Newark, NJ", "Chicken Wings"},
                new string [] {"Tim Broughton", "Detroit, MI", "Chicken Parm"},
                new string [] {"Abby Wessels", "Traverse City, MI", "Soup"},
                new string [] {"Blake Shaw", "Los Angeles, CA", "Cannolis"},
                new string [] {"Bob Valentic", "St. Clair Shores, MI", "Pizza"},
                new string [] {"Jordan Owiesny", "Warren, MI", "Burgers"},
                new string [] {"Jay Stiles", "Macomb, MI", "Pickles"},
                new string [] {"Jon Shaw", "Huntington Woods, MI", "Ribs"}
                 };

            return studentArray[studentNum-1];
        }

        static void displayStudentDirectory()
        {
            Console.WriteLine("");
            int counter = 1;
            while (true)
            {
                try
                {
                    string[] studentDetails = getStudent(counter);
                    Console.WriteLine($"Student {counter++,2} = {studentDetails[0]}");
                }
                catch (IndexOutOfRangeException)
                {
                    break;
                }
            }
        }
    }
}
