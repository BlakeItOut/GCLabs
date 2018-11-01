using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        public static List<Person> PersonList = new List<Person>()
        {
            new Person("Fett, Boba", "Mandalore"),
            new Student("Skywalker, Luke", "Tatooine", "Jedi Training", 1940, 1138),
            new Staff("Kenobi, Obi-Wan", "Stewjon", "Jedi Academy", 0),
            new ArchivedStudent("Skywalker, Leia", "Tatooine", "Diplomatic Training", 2007, 90, 80),
            new ArchivedStudent("Skywalker, Anakin", "Tatooine", "Jedi Training", 1999, 327, 20)
        };
        static void Main(string[] args)
        {
            while (true)
            {
                PersonList.Sort();
                Console.WriteLine("Welcome to the Person Manager!");
                Console.WriteLine("    1. List Person\n    2. Add Person\n    3. Delete Person\n    4. Update Person\n    5. Sort by Last Name\n    6. Sort by Score\n    7. Quit");
                switch (Validator.promptUser("What would you like to do? ", (num => num == "1" || num == "2" || num == "3" || num == "4" || num == "5" || num == "6" || num == "7")))
                {
                    case "1":
                        ListPersons();
                        break;
                    case "2":
                        AddPersonPlus();
                        break;
                    case "3":
                        DeletePerson();
                        break;
                    case "4":
                        UpdatePerson();
                        break;
                    case "5":
                        PersonList.Sort();
                        ListPersons();
                        break;
                    case "6":
                        PersonList.
                            Where(person => person.GetType() == typeof(ArchivedStudent) || person.GetType() == typeof(Student)).
                            OrderByDescending(person => person.GetType() == typeof(ArchivedStudent) ? ((ArchivedStudent)person).FinalScore : 0).ToList().ForEach(Console.WriteLine);
                        break;
                    case "7":
                        if (Validator.promptYN("Are you sure you want to quit? (y/n) "))
                        {
                            return;
                        }
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
        static void ListPersons()
        {
            int counter = 0;
            PersonList.ForEach(Person => Console.WriteLine($"{++counter}: {Person.ToString()}"));
        }
        static void AddPersonPlus()
        {
            Person person = new Person();
            switch (Validator.promptUser("What type of person would you like add?\n  1=General Person\n  2=Staff\n  3=Student\n  4=Archived Student\n", (num => num == "1" || num == "2" || num == "3" || num == "4")))
            {
                case "1":
                    person = MakePerson();
                    break;
                case "2":
                    person = MakeStaff();
                    break;
                case "3":
                    person = MakeStudent();
                    break;
                case "4":
                    person = MakeArchivedStudent();
                    break;
                default:
                    AddPersonPlus();
                    break;
            }
            PersonList.Add(person);
        }

        static ArchivedStudent MakeArchivedStudent()
        {
            Student student = MakeStudent();
            int finalScore = int.Parse(Validator.promptUser("What is their final score? ", (num => int.TryParse(num, out finalScore) && finalScore >= 0 && finalScore <= 100)));
            return new ArchivedStudent(student.Name, student.Address, student.Program, student.Year, student.Fee, finalScore);
        }

        static Student MakeStudent()
        {
            Person person = MakePerson();
            int year = int.Parse(Validator.promptUser("What is their graduating year? ", (num => int.TryParse(num, out year) && year > DateTime.Today.Year-100 && year < DateTime.Today.Year + 100)));
            double fee = double.Parse(Validator.promptUser("What is the fee for this student? ", (num => double.TryParse(num, out fee) && fee > 0.0)));
            return new Student(person.Name, person.Address, Validator.promptUser("What is the program they are on? ", (str => !String.IsNullOrWhiteSpace(str))), year, fee);
        }

        static Staff MakeStaff()
        {
            Person person = MakePerson();
            double pay = double.Parse(Validator.promptUser("What is their pay? ", (num => double.TryParse(num, out pay) && pay > 0.0)));
            return new Staff(person.Name, person.Address, Validator.promptUser("What is the school they work at? ", (str => !String.IsNullOrWhiteSpace(str))), pay);
        }

        static Person MakePerson()
        {
            string firstName = Validator.promptUser("What is the first name of the person? ", (str => !String.IsNullOrWhiteSpace(str) && !str.Contains(" ")));
            string lastName = Validator.promptUser("What is the last name of the person? ", (str => !String.IsNullOrWhiteSpace(str) && !str.Contains(" ")));
            return new Person($"{lastName}, {firstName}", Validator.promptUser("What is this person's address? ", (str => !String.IsNullOrWhiteSpace(str))));
        }
        static void DeletePerson()
        {
            ListPersons();
            int indexToBeRemoved = int.Parse(Validator.promptUser("What is the number of the person you would like to remove? ", (num => int.TryParse(num, out indexToBeRemoved) && indexToBeRemoved > 0 && indexToBeRemoved <= PersonList.Count)));
            if(Validator.promptYN("Are you sure you want to remove this person? (y/n) "))
            {
                PersonList.RemoveAt(indexToBeRemoved-1);
            } 
        }
        static void UpdatePerson()
        {
            ListPersons();
            int indexToBeUpdated = int.Parse(Validator.promptUser("What is the number of the person you would like to update? ", (num => int.TryParse(num, out indexToBeUpdated) && indexToBeUpdated > 0 && indexToBeUpdated <= PersonList.Count)));
            PersonList[indexToBeUpdated-1].Name = Validator.promptUser($"What would you like to change the name to? ", (str => !String.IsNullOrWhiteSpace(str)));
            PersonList[indexToBeUpdated-1].Address = Validator.promptUser($"What would you like to change the address to? ", (str => !String.IsNullOrWhiteSpace(str)));
        }
    }
}
