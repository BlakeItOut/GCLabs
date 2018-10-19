using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone2
{
    class Book : System.IComparable<Book>
    {
        public string title { get; set; }
        public string author { get; set; }
        public bool checkedOut { get; set; } = false;
        public DateTime? dueDate { get; set; } = null;

        public int CompareTo(Book that)
        {
            return this.title.ToLower().Replace("the", "").Replace("a", "").Replace("an", "").Trim().CompareTo(that.title.ToLower().Replace("the", "").Replace("a", "").Replace("an", "").Trim());
        }
    }
}
