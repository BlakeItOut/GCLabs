using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Exercises obj = new Exercises();
                Console.Write("What exercise # would you like to go to? ");
                int response = int.Parse(Console.ReadLine());
                if(response > 0)
                {
                    MethodInfo method = obj.GetType().GetMethod($"Exercise{response}");
                    method.Invoke(obj, null);
                }
                else
                {
                    MethodInfo method = obj.GetType().GetMethod($"ExerciseB{response*-1}");
                    method.Invoke(obj, null);
                }
            }
        }
    }

    public class Exercises
    {
        public Exercises()
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
        public void Exercise0()
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
            Exercises obj = new Exercises();
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
            string[][] studentData = {
                new string [] {"Michael Hern", "Canton, MI","Chicken Wings", "Wolverine"},
                new string [] {"Taylor Everts", "Caro, MI", "Cordon Bleu", "Chicken"},
                new string [] {"Joshua Zimmerman", "Taylor, MI", "Turkey", "Sloth"},
                new string [] {"Lin-Z Chang", "Toledo, OH", "Ice Cream", "Honey Badger"},
                new string [] {"Madelyn Hilty", "Oxford, MI", "Croissent", "Dragon"},
                new string [] {"Nana Banahene", "Guana", "Empanadas", "Zebra"},
                new string [] {"Rochelle Toles", "Mars", "Space Cheese", "Racoon"},
                new string [] {"Shah Shahid", "Newark, NJ", "Chicken Wings", "Eagle"},
                new string [] {"Tim Broughton", "Detroit, MI", "Chicken Parm", "Hedgehog"},
                new string [] {"Abby Wessels", "Traverse City, MI", "Soup", "Doe"},
                new string [] {"Blake Shaw", "Los Angeles, CA", "Cannolis", "Bat"},
                new string [] {"Bob Valentic", "St. Clair Shores, MI", "Pizza", "Octopus"},
                new string [] {"Jordan Owiesny", "Warren, MI", "Burgers", "Penguin"},
                new string [] {"Jay Stiles", "Macomb, MI", "Pickles", ""},
                new string [] {"Jon Shaw", "Huntington Woods, MI", "Ribs", "Dog"}
                 };
            for (int i = 0; i < studentData.Length; i++)
            {
                Console.WriteLine("new StudentInfo() { Name = \"" + $"{studentData[i][0]}\", hometown = \"{studentData[i][1]}\", favFood = \"{studentData[i][2]}\", favAnimal = \"{studentData[i][3]}\"" + "},");
            }
        }
        public void Exercise22()
        {

        }
        public void Exercise23()
        {

        }
        public void Exercise24()
        {

        }
        public void Exercise25()
        {

        }
        public void Exercise26()
        {

        }
        public void Exercise27()
        {

        }
        public void Exercise28()
        {

        }
        public void Exercise29()
        {

        }
        public void Exercise30()
        {

        }
        public void Exercise31()
        {

        }
        public void Exercise32()
        {

        }
        public void Exercise33()
        {

        }
        public void Exercise34()
        {

        }
        public void Exercise35()
        {

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
