using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ActualExercises obj = new ActualExercises();
                askExerciseNumber:
                Console.Write("What exercise # would you like to go to? ");
                int response = -23;
                if (!int.TryParse(Console.ReadLine(), out response) || response < -22 || response > 78) {
                    goto askExerciseNumber;
                }
                if (response == 0)
                {
                    break;
                }
                else if(response > 0 && response < 26)
                {
                    MethodInfo method = obj.GetType().GetMethod($"Exercise{response}");
                    method.Invoke(obj, null);
                }
                else if (response > 25)
                {
                    MethodInfo method = obj.GetType().GetMethod($"Exercise{response}");
                    continueLoop((Action) Delegate.CreateDelegate(typeof(Action), obj, method));
                }
                else
                {
                    MethodInfo method = obj.GetType().GetMethod($"ExerciseB{response*-1}");
                    method.Invoke(obj, null);
                }
            }
        }
        static void continueLoop(Action methodName)
        {
            while (true)
            {
                methodName();
            continueQuestion:
                Console.Write("Would you like to continue (y/n)? ");
                char response = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine("");
                if (response == 'y')
                {
                    continue;
                }
                else if (response == 'n')
                {
                    break;
                }
                else
                {
                    Console.Write("That is not a valid response.");
                    goto continueQuestion;
                }
            }
            Console.WriteLine("Goodbye!");
        }
    }

    public class ActualExercises
    {
        public ActualExercises()
        {

        }
        public void ExerciseB22()
        {

        }
        public void ExerciseB21()
        {

        }
        public void ExerciseB20()
        {

        }
        public void ExerciseB19()
        {

        }
        public void ExerciseB18()
        {

        }
        public void ExerciseB17()
        {

        }
        public void ExerciseB16()
        {

        }
        public void ExerciseB15()
        {

        }
        public void ExerciseB14()
        {

        }
        public void ExerciseB13()
        {

        }
        public void ExerciseB12()
        {

        }
        public void ExerciseB11()
        {

        }
        public void ExerciseB10()
        {

        }
        public void ExerciseB9()
        {

        }
        public void ExerciseB8()
        {

        }
        public void ExerciseB7()
        {

        }
        public void ExerciseB6()
        {

        }
        public void ExerciseB5()
        {

        }
        public void ExerciseB4()
        {

        }
        public void ExerciseB3()
        {

        }
        public void ExerciseB2()
        {

        }
        public void ExerciseB1()
        {

        }
        public void Exercise1()
        {
            Console.Write("Enter some text: ");
            string echo = Console.ReadLine();
            Console.WriteLine(echo);
        }
        public void Exercise2()
        {
            Console.Write("Enter a number: ");
            int numPlus = int.Parse(Console.ReadLine());
            Console.WriteLine(numPlus+1);
        }
        public void Exercise3()
        {
            Console.Write("Enter a number: ");
            double numPlus = double.Parse(Console.ReadLine());
            Console.WriteLine(numPlus + .5);
        }
        public void Exercise4()
        {
            Console.Write("Enter a number: ");
            double numPlus = double.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            double numPlus2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"The sum is {numPlus + numPlus2}");
        }
        public void Exercise5()
        {
            Console.Write("Enter a number: ");
            double numPlus = double.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            double numPlus2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"The product is {numPlus * numPlus2}");
        }
        public void Exercise6()
        {
            do
            {
                Console.WriteLine("Hello, World!");
                wrongInput:
                Console.Write("Would you like to continue (y/n)? ");
                char response = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine("");
                if (response == 'y')
                {
                    continue;
                }
                else if (response == 'n')
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("This input is not valid. Please try again.");
                    goto wrongInput;
                }
            } while (true);
        }
        public void Exercise7()
        {
            do
            {
                Exercise1();
                wrongInput:
                Console.Write("Would you like to continue (y/n)? ");
                char response = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine("");
                if (response == 'y')
                {
                    continue;
                }
                else if (response == 'n')
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("This input is not valid. Please try again.");
                    goto wrongInput;
                }
            } while (true);
        }
        public void Exercise8()
        {
            ActualExercises obj = new ActualExercises();
            for (int i = 2; i <= 5; i++)
            {
                do
                {
                    MethodInfo method = obj.GetType().GetMethod($"Exercise{i}");
                    method.Invoke(obj, null);
                    wrongInput:
                    Console.Write("Would you like to continue (y/n)? ");
                    char response = char.ToLower(Console.ReadKey().KeyChar);
                    Console.WriteLine("");
                    if (response == 'y')
                    {
                        continue;
                    }
                    else if (response == 'n')
                    {
                        Console.WriteLine("Goodbye!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("This input is not valid. Please try again.");
                        goto wrongInput;
                    }
                } while (true);
            }
        }
        public void Exercise9()
        {
            char response;
            do
            {
                Console.Write("Enter a language: ");
                string language = Console.ReadLine();
                switch (language.ToLower())
                {
                    case "english":
                        Console.WriteLine("Hello, World!");
                        break;
                    case "spanish":
                        Console.WriteLine("Hola Mundo!");
                        break;
                    case "dutch":
                        Console.WriteLine("Hallo wereld!");
                        break;
                    default:
                        break;
                }
                wrongInput:
                Console.Write("Would you like to continue (y/n)? ");
                response = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine("");
                if (response == 'y')
                {
                    continue;
                }
                else if (response != 'n')
                {
                    Console.WriteLine("This input is not valid. Please try again.");
                    goto wrongInput;
                }
            } while (response != 'n');
            Console.WriteLine("Goodbye!");
        }
        public void Exercise10()
        {
            char response;
            do
            {
                Console.Write("Enter your height in inches: ");
                double height = Convert.ToDouble(Console.ReadLine());
                if (height < 54)
                {
                    Console.WriteLine($"Sorry, you cannot ride the Raptor. You need {54 - height} more inches.");
                }
                else
                {
                    Console.WriteLine("Great, you can ride the Raptor!");
                }
                wrongInput:
                Console.Write("Would you like to continue (y/n)? ");
                response = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine("");
                if (response == 'y')
                {
                    continue;
                }
                else if (response != 'n')
                {
                    Console.WriteLine("This input is not valid. Please try again.");
                    goto wrongInput;
                }
            } while (response != 'n');
            Console.WriteLine("Goodbye!");
        }
        public void Exercise11()
        {
            char response;
            do
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine("");
                Console.Write("Would you like to continue (y/n)? ");
                response = char.ToLower(Console.ReadLine()[0]);
            } while (response != 'n');
            Console.WriteLine("Goodbye!");
        }
        public void Exercise12()
        {
            char response;
            do
            {
                for (int i = 9; i >= 0; i--)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine("");
                Console.Write("Would you like to continue (y/n)? ");
                response = char.ToLower(Console.ReadLine()[0]);
            } while (response != 'n');
            Console.WriteLine("Goodbye!");
        }
        public void Exercise13()
        {
            char response;
            do
            {
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());
                for (int i = num; i >= 0; i--)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine("");
                Console.Write("Would you like to continue (y/n)? ");
                response = char.ToLower(Console.ReadLine()[0]);
            } while (response != 'n');
            Console.WriteLine("Goodbye!");
        }
        public void Exercise14()
        {
            char response;
            do
            {
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());
                for (int i = 1; i <= num; i++)
                {
                    Console.Write(Math.Pow(i,2) + " ");
                }
                Console.WriteLine("");
                Console.Write("Would you like to continue (y/n)? ");
                response = char.ToLower(Console.ReadLine()[0]);
            } while (response != 'n');
            Console.WriteLine("Goodbye!");
        }
        public void Exercise15()
        {
            char response;
            do
            {
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());
                for (int i = 1; i <= num; i++)
                {
                    Console.Write(Math.Pow(i, 3) + " ");
                }
                Console.WriteLine("");
                Console.Write("Would you like to continue (y/n)? ");
                response = char.ToLower(Console.ReadLine()[0]);
            } while (response != 'n');
            Console.WriteLine("Goodbye!");
        }
        public void Exercise16()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
        public void Exercise17()
        {
            int num = 10;
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= (num-i); j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }

        }
        public void Exercise18()
        {
            char response;
            do
            {
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());
                int sum = 0;
                for (int i = 1; i <= num; i++)
                {
                    sum += i;
                }
                Console.WriteLine(sum);
                Console.Write("Would you like to continue (y/n)? ");
                response = char.ToLower(Console.ReadLine()[0]);
            } while (response != 'n');
            Console.WriteLine("Goodbye!");
        }
        public void Exercise19()
        {
            char response;
            do
            {
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = int.Parse(Console.ReadLine());
                int sum = 0;
                for (int i = num; i <= num2; i++)
                {
                    sum += i;
                }
                Console.WriteLine($"The sum of all the numbers from {num} to {num2} is {sum}.");
                Console.Write("Would you like to continue (y/n)? ");
                response = char.ToLower(Console.ReadLine()[0]);
            } while (response != 'n');
            Console.WriteLine("Goodbye!");
        }
        public void Exercise20()
        {
            char response;
            do
            {
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());
                int product = num;
                for (int i = num-1; i >= num-2; i--)
                {
                    product *= i;
                }
                Console.WriteLine($"The produce of {num}, {num-1}, and {num-2} is {product}.");
                Console.Write("Would you like to continue (y/n)? ");
                response = char.ToLower(Console.ReadLine()[0]);
            } while (response != 'n');
            Console.WriteLine("Goodbye!");
        }
        public void Exercise21()
        {
            while(true)
            {
                string sentence = "";
                while (true)
                {
                    Console.Write("Enter a word: ");
                    sentence += Console.ReadLine();
                    Console.Write("Would you like to enter another word (y/n)? ");
                    if (Char.ToLower(Console.ReadKey().KeyChar) == 'n')
                    {
                        Console.WriteLine("");
                        break;
                    }
                    sentence += " ";
                    Console.WriteLine("");
                }
                Console.WriteLine(sentence);
                Console.Write("Would you like to continue (y/n)? ");
                if (Char.ToLower(Console.ReadKey().KeyChar) == 'n')
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                Console.WriteLine("");
            }
        }
        public void Exercise22()
        {
            Console.Write("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your range is {num1}-{num2}.");
            while (true)
            {
                Console.Write("Enter a number to verify it is in the range: ");
                int numToCheck = int.Parse(Console.ReadLine());
                if (numToCheck >= num1 && numToCheck <= num2)
                {
                    Console.WriteLine($"{numToCheck} is in the range.");
                }
                else
                {
                    Console.WriteLine($"{numToCheck} is outside the range.");
                }
                Console.Write("Would you like to continue (y/n)? ");
                if (Char.ToLower(Console.ReadKey().KeyChar) == 'n')
                {
                    Console.WriteLine("");
                    Console.WriteLine("Goodbye!");
                    break;
                }
                Console.WriteLine("");
            }
        }
        public void Exercise23()
        {
            while (true)
            {
                Console.Write("Enter some text: ");
                string userInput = Console.ReadLine();
                Console.WriteLine($"The first ten characters were: {userInput.Substring(0, 10)}");
                Console.Write("Would you like to continue (y/n)? ");
                if (Char.ToLower(Console.ReadKey().KeyChar) == 'n')
                {
                    Console.WriteLine("");
                    Console.WriteLine("Goodbye!");
                    break;
                }
                Console.WriteLine("");
            }
        }
        public void Exercise24()
        {
            while (true)
            {
                Console.Write("Enter some text: ");
                string userInput = Console.ReadLine();
                Console.WriteLine($"The last ten characters were: {userInput.Substring(userInput.Length-10)}");
                Console.Write("Would you like to continue (y/n)? ");
                if (Char.ToLower(Console.ReadKey().KeyChar) == 'n')
                {
                    Console.WriteLine("");
                    Console.WriteLine("Goodbye!");
                    break;
                }
                Console.WriteLine("");
            }
        }
        public void Exercise25()
        {
            char response;
            do
            {
                Console.Write("Enter a sentence: ");
                foreach (string word in Console.ReadLine().Split(' '))
                {
                    Console.WriteLine(word);
                }
                Console.Write("Would you like to continue (y/n)? ");
                response = char.ToLower(Console.ReadLine()[0]);
            } while (response != 'n');
            Console.WriteLine("Goodbye!");
        }
        public void Exercise26()
        {
            Console.Write("Enter some text: ");
            Console.WriteLine($"There were {Console.ReadLine().ToLower().Count(c => Regex.IsMatch(c.ToString(), @"[aeiou]"))} vowels.");
        }
        public void Exercise27()
        {
            Console.Write("Enter some text: ");
            Console.WriteLine($"There were {Console.ReadLine().ToLower().Count(c => Regex.IsMatch(c.ToString(), @"[b-df-hj-np-tv-z]"))} consonants.");
        }
        public void Exercise28()
        {
            Console.Write("Enter some text: ");
            Console.WriteLine(Console.ReadLine().Where(c => Regex.IsMatch(c.ToString(), @"[^AEIOUaeiou]")).ToArray());
        }
        public void Exercise29()
        {
            Console.Write("Enter some text: ");
            string text = Console.ReadLine();
            string outputText = text[0].ToString();
            for(int i = 1; i < text.Length-1; i++)
            {
                if(Char.IsPunctuation(text[i]) || Char.IsPunctuation(text[i+1]) || Char.IsWhiteSpace(text[i]) || Char.IsWhiteSpace(text[i+1]) || Char.IsWhiteSpace(text[i-1]) || Regex.IsMatch(text[i].ToString(), @"[^AEIOUaeiou]"))
                {
                    outputText += text[i];
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(outputText + text[text.Length - 1]);
        }
        public void Exercise30()
        {
            Console.Write("Enter some text: ");
            Console.WriteLine(new string(Console.ReadLine().ToCharArray().Reverse().ToArray()));
        }
        public void Exercise31()
        {
            int[] numbers = { 2, 8, 0, 24, 51 };
            Console.Write("Enter an index of the array: ");
            int index;
            bool checkIndexInt = int.TryParse(Console.ReadLine(), out index);
            if (checkIndexInt && index < numbers.Length)
            {
                Console.WriteLine($"The value at index {index} is {numbers[index]}");
            }
            else
            {
                Console.WriteLine("That is not a valid index.");
            }
        }
        public void Exercise32()
        {
            int[] numbers = { 2, 8, 0, 24, 51 };
            Console.Write("Enter a number: ");
            int number;
            bool checkIndexInt = int.TryParse(Console.ReadLine(), out number);
            if (checkIndexInt && numbers.Contains(number))
            {
                Console.WriteLine($"The value {number} can be found at {Array.IndexOf(numbers, number)}");
            }
            else
            {
                Console.WriteLine("That value cannot be found in the array.");
            }
        }

        public int[] numbers = { 2, 8, 0, 24, 51 };

        public void Exercise33()
        {
            Console.Write("Enter an index of the array: ");
            int index;
            bool checkIndexInt = int.TryParse(Console.ReadLine(), out index);
            if (checkIndexInt && index < numbers.Length)
            {
                Console.Write($"The value at index {index} is {numbers[index]}. Would you like to change it (y/n)? ");
                if(Char.ToLower(Console.ReadLine()[0]) == 'y')
                {
                    Console.Write($"Enter the new value at index {index}: ");
                    numbers[index] = int.Parse(Console.ReadLine());
                    Console.Write($"The value at index {index} is {numbers[index]}. ");
                }
            }
            else
            {
                Console.WriteLine("That is not a valid index.");
            }
        }
        public void Exercise34()
        {

        }
        public string textValue;
        public int numberValue;
        public void Exercise35()
        {
            int arraySize = int.Parse(promptUser("How many string would you like to use? ", (str => Regex.IsMatch(str,@"^[0-9]*$"))));
            string[] arrayOfStrings = new string[arraySize];
            for(int i = 0; i < arraySize; i++)
            {
                arrayOfStrings[i] = promptUser($"What would you like for your string at index {i}? ", (str => true));
            }
            arrayOfStrings.ToList().ForEach(Console.WriteLine);
            do
            {
                getValue(arrayOfStrings);
            } while (promptUser("Would you like to get another value? (y/n) ", (str => str.ToLower()[0] == 'y' || str.ToLower()[0] == 'n')).ToLower()[0] == 'y');
        }

         public void getValue(string[] arrayOfStrings)
        {
            int arrayIndex = int.Parse(promptUser("What array index would you like to use? ", (str => int.TryParse(str, out numberValue) && numberValue < arrayOfStrings.Length && numberValue >= 0)));
            int stringIndex = int.Parse(promptUser("What string index would you like to use? ", (str => int.TryParse(str, out numberValue) && numberValue < arrayOfStrings[arrayIndex].Length && numberValue >= 0)));
            Console.WriteLine($"The value at index {arrayIndex} is {arrayOfStrings[arrayIndex]}. The letter at index {stringIndex} is {arrayOfStrings[arrayIndex][stringIndex]}.");
        }

        static string promptUser(string message, Func<string, bool> condition)
        {
            Console.Write(message);
            string textValue = Console.ReadLine();
            if (condition(textValue))
            {
                return textValue;
            }
            else
            {
                Console.WriteLine("This is not valid input.");
                return promptUser(message, condition);
            }
        }
        public void Exercise36()
        {

        }
        public void Exercise37()
        {

        }
        public void Exercise38()
        {

        }
        public void Exercise39()
        {

        }
        public void Exercise40()
        {

        }
        public void Exercise41()
        {

        }
        public void Exercise42()
        {

        }
        public void Exercise43()
        {

        }
        public void Exercise44()
        {

        }
        public void Exercise45()
        {

        }
        public void Exercise46()
        {

        }
        public void Exercise47()
        {

        }
        public void Exercise48()
        {

        }
        public void Exercise49()
        {

        }
        public void Exercise50()
        {

        }
        public void Exercise51()
        {

        }
        public void Exercise52()
        {

        }
        public void Exercise53()
        {

        }
        public void Exercise54()
        {

        }
        public void Exercise55()
        {

        }
        public void Exercise56()
        {

        }
        public void Exercise57()
        {

        }
        public void Exercise58()
        {

        }
        public void Exercise59()
        {

        }
        public void Exercise60()
        {

        }
        public void Exercise61()
        {

        }
        public void Exercise62()
        {

        }
        public void Exercise63()
        {

        }
        public void Exercise64()
        {

        }
        public void Exercise65()
        {

        }
        public void Exercise66()
        {

        }
        public void Exercise67()
        {

        }
        public void Exercise68()
        {

        }
        public void Exercise69()
        {

        }
        public void Exercise70()
        {

        }
        public void Exercise71()
        {

        }
        public void Exercise72()
        {

        }
        public void Exercise73()
        {

        }
        public void Exercise74()
        {

        }
        public void Exercise75()
        {

        }
        public void Exercise76()
        {

        }
        public void Exercise77()
        {

        }
        public void Exercise78()
        {

        }
    }


}
