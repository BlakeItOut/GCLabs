using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<StudentInfo> students = new List<StudentInfo>
            {
                new StudentInfo() { name = "Michael Hern", hometown = "Canton, MI", favFood = "Chicken Wings", favAnimal = "Wolverine"},
                new StudentInfo() { name = "Taylor Everts", hometown = "Caro, MI", favFood = "Cordon Bleu", favAnimal = "Chicken"},
                new StudentInfo() { name = "Joshua Zimmerman", hometown = "Taylor, MI", favFood = "Turkey", favAnimal = "Sloth"},
                new StudentInfo() { name = "Lin-Z Chang", hometown = "Toledo, OH", favFood = "Ice Cream", favAnimal = "Honey Badger"},
                new StudentInfo() { name = "Madelyn Hilty", hometown = "Oxford, MI", favFood = "Croissent", favAnimal = "Dragon"},
                new StudentInfo() { name = "Nana Banahene", hometown = "Guana", favFood = "Empanadas", favAnimal = "Zebra"},
                new StudentInfo() { name = "Rochelle Toles", hometown = "Mars", favFood = "Space Cheese", favAnimal = "Racoon"},
                new StudentInfo() { name = "Shah Shahid", hometown = "Newark, NJ", favFood = "Chicken Wings", favAnimal = "Eagle"},
                new StudentInfo() { name = "Tim Broughton", hometown = "Detroit, MI", favFood = "Chicken Parm", favAnimal = "Hedgehog"},
                new StudentInfo() { name = "Abby Wessels", hometown = "Traverse City, MI", favFood = "Soup", favAnimal = "Doe"},
                new StudentInfo() { name = "Blake Shaw", hometown = "Los Angeles, CA", favFood = "Cannolis", favAnimal = "Bat"},
                new StudentInfo() { name = "Bob Valentic", hometown = "St. Clair Shores, MI", favFood = "Pizza", favAnimal = "Octopus"},
                new StudentInfo() { name = "Jordan Owiesny", hometown = "Warren, MI", favFood = "Burgers", favAnimal = "Penguin"},
                new StudentInfo() { name = "Jay Stiles", hometown = "Macomb, MI", favFood = "Pickles", favAnimal = "Otter"},
                new StudentInfo() { name = "Jon Shaw", hometown = "Huntington Woods, MI", favFood = "Ribs", favAnimal = "Dog"}
            };

            students.Sort();
            
            Console.Write($"Welcome to our C# class. ");

            bool quit = false;

            while (!quit)
            {
                Console.Write("Would you like to lookup(l), add(a), or quit(q)? ");
                char responseKey = Char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine("");
                Console.WriteLine("");
                switch (responseKey)
                {
                    case 'l':
                        lookUp(students);
                        break;
                    case 'a':
                        addNewStudent(ref students);
                        break;
                    case 'q': 
                        quit = true;
                        Console.Write("Thanks");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Write("That is not a valid response. Please try again. (enter \"l\", \"a\", or \"q\"): ");
                        continue;
                }
            }
        }

        static void addNewStudent(ref List<StudentInfo> students)
        {
            StudentInfo newStudent = makeStudent();
            students.Insert(~(students.BinarySearch(newStudent)),newStudent);
        }

        static StudentInfo makeStudent ()
        {
            return new StudentInfo() { name = makeDetail("What is the students name? "), hometown = makeDetail("What is their hometown? "), favFood = makeDetail("What is their favorite food? "), favAnimal = makeDetail("What is their favorite animal? ") };
        }

        static string makeDetail(string message)
        {
            Console.Write(message);
            string detail = Console.ReadLine();
            Console.WriteLine("");
            if (string.IsNullOrWhiteSpace(detail))
            {
                return makeDetail(message);
            }
            else
            {
                return detail;
            }

        }

        static void lookUp (List<StudentInfo> students)
        {
            StudentInfo studentDetails = getStudent(students);
            Console.Write($"Student {students.IndexOf(studentDetails)+1} is {studentDetails.name}. What would you like to know about {studentDetails.name.Split(' ')[0]}? (enter \"hometown\", \"favorite food\", or \"favorite animal\"): ");
            getDetailChoice(studentDetails);
        }

        static void getDetailChoice(StudentInfo studentDetails)
        {
            string detail = Console.ReadLine().ToLower();
            Console.WriteLine("");
            switch (detail)
            {
                case "hometown":
                    Console.Write($"{studentDetails.name.Split(' ')[0]} is from {studentDetails.hometown}. ");
                    break;
                case "favorite food":
                    Console.Write($"{studentDetails.name.Split(' ')[0]} likes to eat {studentDetails.favFood}. ");
                    break;
                case "favorite animal":
                    Console.Write($"{studentDetails.name.Split(' ')[0]}'s favorite animal is the {studentDetails.favAnimal}. ");
                    break;
                default:
                    Console.Write("That data does not exist. Please try again. (enter \"hometown\", \"favorite food\", or \"favorite animal\"): ");
                    getDetailChoice(studentDetails);
                    break;
            }
        }

        static StudentInfo getStudent(List<StudentInfo> students)
        {
            Console.Write($"Which other student would you like to learn more about? (enter a number 1-{students.Count}): ");
            try
            {
                int studentNum = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                return students[studentNum-1];
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.Write("That student does not exist. Press any key to see a directory or enter \"skip\" to skip: ");
                if (Console.ReadLine() != "skip")
                {
                    Console.WriteLine("");
                    int counter = 1;
                    foreach (StudentInfo student in students)
                    {
                        Console.WriteLine($"Student {counter++,2} = {student.name}");
                    }
                }
                Console.WriteLine("");
                return getStudent(students);
            }
            catch (FormatException)
            {
                Console.WriteLine("");
                Console.Write("That is not a whole number. ");
                return getStudent(students);
            }
        }
    }
}
