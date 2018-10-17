using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class StudentInfo : System.IComparable<StudentInfo>
    {
        public string name { get; set; }
        public string hometown { get; set; }
        public string favFood { get; set; }
        public string favAnimal { get; set; }

        public int CompareTo(StudentInfo that)
        {
            return this.name.CompareTo(that.name);
        }
    }
}
