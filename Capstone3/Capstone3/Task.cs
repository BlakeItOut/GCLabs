using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capstone3
{
    public class Task : IComparable<Task>
    {
        public string AssignedTo { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool Completed { get; set; } = false;
        public Task ()
        {

        }
        public Task (string assignedTo, string description, DateTime? dueDate)
        {
            AssignedTo = assignedTo;
            Description = description;
            DueDate = dueDate.Value;
        }

        public int getDaysRemaining(DateTime? tester = null)
        {
            DateTime dateTime = tester == null ? DateTime.Today : tester.Value;
            return (int)(DueDate.Subtract(dateTime)).TotalDays;
        }

        public override string ToString()
        {
            return $"{Completed,-15}{DueDate,-15:d}{AssignedTo,-15}{Description}";
        }

        public int CompareTo(Task that)
        {
            int result = this.DueDate.CompareTo(that.DueDate);
            return (result == 0) ? -1 : result;
        }
    }
}
