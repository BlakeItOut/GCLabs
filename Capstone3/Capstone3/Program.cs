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
            new Task() {AssignedTo = "Tom", DueDate = new DateTime(2018,10,31)},
            new Task() {AssignedTo = "Tammy", DueDate = new DateTime(2018,11,1)},
            new Task() {AssignedTo = "Tom", DueDate = new DateTime(2018,11,2)},
            new Task() {AssignedTo = "Tammy", DueDate = new DateTime(2018,11,3)},
            new Task() {AssignedTo = "Tom", DueDate = new DateTime(2018,11,4)},
            new Task() {AssignedTo = "Edwardo", DueDate = new DateTime(2018,11,5)}
        };
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to the Task Manager!\n    1. List task\n    2. Add task\n    3. Delete task\n    4. Mark task complete\n    5. Filter by team member name\n    6. Filter by due date\n    7. Update task\n    8. Quit");
                switch (Validator.promptUser("What would you like to do? ", (num => num=="1" || num == "2" || num == "3" || num == "4" || num == "5" || num == "6" || num == "7" || num == "8")))
                {
                    case "1":
                        ListTasks(TaskList);
                        break;
                    case "2":
                        AddTask(TaskList);
                        break;
                    case "3":
                        DeleteTask(TaskList);
                        break;
                    case "4":
                        MarkTaskComplete(TaskList);
                        break;
                    case "5":
                        FilterByName();
                        break;
                    case "6":
                        FilterByDate();
                        break;
                    case "7":
                        UpdateTask(TaskList);
                        break;
                    case "8":
                        Console.WriteLine("Have a great day!");
                        Console.ReadKey();
                        return;
                    default:
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
        static void ListTasks(List<Task> taskList)
        {
            Console.WriteLine("");
            Console.WriteLine("LIST TASKS");
            int counter = 0;
            Console.WriteLine($"{"Index",-7}{"Done?",-15}{"Due Date",-15:d}{"Team Member",-15}Description");
            taskList.ForEach(task => Console.WriteLine($"  {++counter,-5}{task.ToString()}"));
        }
        static void AddTask(List<Task> taskList)
        {
            Console.WriteLine("");
            Console.WriteLine("ADD TASK");
            string teamMember = Validator.promptUser("Team member name: ", (str => !String.IsNullOrWhiteSpace(str)));
            string description = Validator.promptUser("Task description: ", (str => !String.IsNullOrWhiteSpace(str)));
            DateTime dueDate = DateTime.Parse(Validator.promptUser("Due Date: ", (date => DateTime.TryParse(date, out dueDate))));
            Task taskToAdd = new Task() {AssignedTo=teamMember, Description = description, DueDate = dueDate};
            taskList.Insert(~taskList.BinarySearch(taskToAdd), taskToAdd);
        }
        static void DeleteTask(List<Task> taskList)
        {
            int indexToBeDeleted = GetIndex(taskList, "What is the number of the task you would like to delete? ", "Are you sure you want to delete this task? (y/n) ");
            if (indexToBeDeleted != -1)
            {
                taskList[indexToBeDeleted- 1].Completed = true;
            }
        }
        static void MarkTaskComplete(List<Task> taskList)
        {
            int indexToBeCompleted = GetIndex(taskList, "What is the number of the task you would like to complete? ", "Are you sure you want to complete this task? (y/n) ");
            if (indexToBeCompleted != -1)
            {
                taskList[indexToBeCompleted - 1].Completed = true;
            }
        }
        static void FilterByName()
        {
            string assignedTo = Validator.promptUser("Team Member Name: ", (str => !String.IsNullOrWhiteSpace(str)));
            ListTasks(TaskList.Where(task => task.AssignedTo.IndexOf(assignedTo, StringComparison.OrdinalIgnoreCase) >= 0).ToList());
        }
        static void FilterByDate()
        {
            DateTime dueBefore = DateTime.Parse(Validator.promptUser("Due Before: ", (date => DateTime.TryParse(date, out dueBefore))));
            ListTasks(TaskList.Where(task => task.DueDate.CompareTo(dueBefore)<0).ToList());
        }
        static void UpdateTask(List<Task> taskList)
        {
            int indexToBeUpdated = GetIndex(taskList, "What is the number of the task you would like to complete? ", "Are you sure you want to update this task? (y/n) ");
            if (indexToBeUpdated != -1)
            {
                taskList[indexToBeUpdated - 1].AssignedTo = Validator.promptUser($"Current team member name: {taskList[indexToBeUpdated - 1].AssignedTo} => Update: ", (str => !String.IsNullOrWhiteSpace(str)));
                taskList[indexToBeUpdated - 1].Description = Validator.promptUser($"Current description: {taskList[indexToBeUpdated - 1].Description} => Update: ", (str => !String.IsNullOrWhiteSpace(str)));
                DateTime dueDate = DateTime.Parse(Validator.promptUser($"Current due date: {taskList[indexToBeUpdated - 1].DueDate:d} => Update: ", (date => DateTime.TryParse(date, out dueDate))));
                taskList[indexToBeUpdated - 1].DueDate = dueDate;
            }
        }

        static int GetIndex(List<Task> taskList, string message, string confirmationMessage)
        {
            ListTasks(taskList);
            int indexToBeActedOn = int.Parse(Validator.promptUser(message, (num => int.TryParse(num, out indexToBeActedOn) && indexToBeActedOn > 0 && indexToBeActedOn <= taskList.Count)));
            if (Validator.promptYN(confirmationMessage))
            {
                return indexToBeActedOn;
            }
            return -1;
        }
    }
}
