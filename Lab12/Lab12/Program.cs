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
            new Person(),
            new Student(),
            new Staff()
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Person Manager!");
            while (true)
            {
                Console.WriteLine("    1. List Person\n    2. Add Person\n    3. Delete Person\n    4. Update Person\n    5. Quit");
                switch (Validator.promptUser("What would you like to do? ", (num => num == "1" || num == "2" || num == "3" || num == "4" || num == "5")))
                {
                    case "1":
                        ListPersons();
                        break;
                    case "2":
                        AddPerson();
                        break;
                    case "3":
                        DeletePerson();
                        break;
                    case "4":
                        UpdatePerson();
                        break;
                    case "5":
                        if (Validator.promptYN("Are you sure you want to quit? (y/n) "))
                        {
                            return;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        static void ListPersons()
        {
            int counter = 0;
            PersonList.ForEach(Person => Console.WriteLine($"{++counter}: {Person.ToString()}"));
        }
        static void AddPerson()
        {
            PersonList.Add(new Person(Validator.promptUser("What is the name of the person? ",(str => !String.IsNullOrWhiteSpace(str))), Validator.promptUser("What is this person's address? ", (str => !String.IsNullOrWhiteSpace(str)))));
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
