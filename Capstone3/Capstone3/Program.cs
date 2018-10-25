using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone3
{
    class Program
    {
        public static List<Task> TaskList = new List<Task>()
        {
            new Task(),
            new Task()
        };
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to the Task Manager!\n    1. List task\n    2. Add task\n    3. Delete task\n    4. Mark task complete\n    5. Quit");
                switch (Validator.promptUser("What would you like to do? ", (num => num=="1" || num == "2" || num == "3" || num == "4" || num == "5")))
                {
                    case "1":
                        ListTasks();
                        break;
                    case "2":
                        AddTask();
                        break;
                    case "3":
                        DeleteTask();
                        break;
                    case "4":
                        MarkTaskComplete();
                        break;
                    case "5":
                        if (Validator.promptContinue())
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
        static void ListTasks()
        {
            int counter = 0;
            Console.WriteLine($"{"Index",-7}{"Done?",-15}{"Due Date",-15:d}{"Team Member",-15}Description");
            TaskList.ForEach(task => Console.WriteLine($"  {++counter,-5}{task.ToString()}"));
        }
        static void AddTask()
        {
            Console.WriteLine("");
            Console.WriteLine("ADD TASK");
            string teamMember = Validator.promptUser("Team member name: ", (str => !String.IsNullOrWhiteSpace(str)));
            string description = Validator.promptUser("Task description: ", (str => !String.IsNullOrWhiteSpace(str)));
            DateTime dueDate = DateTime.Parse(Validator.promptUser("Due Date: ", (date => DateTime.TryParse(date, out dueDate))));
            Task taskToAdd = new Task() {AssignedTo=teamMember, Description = description, DueDate = dueDate};
            TaskList.Insert(~TaskList.BinarySearch(taskToAdd), taskToAdd);
        }
        static void DeleteTask()
        {

        }
        static void MarkTaskComplete()
        {

        }
    }
}
