using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class ArchivedStudent : Student, IComparable<ArchivedStudent>
    {
        public int FinalScore { get; set; }
        public ArchivedStudent()
        {

        }
        public ArchivedStudent(string name, string address, string program, int year, double fee, int finalScore) : base(name, address, program, year, fee)
        {
            FinalScore = finalScore;
        }

        public override string ToString()
        {
            return base.ToString() + $", final score={FinalScore}";
        }
        public int CompareTo(ArchivedStudent that)
        {
            string[] thatName = that.Name.Split(' ');
            string[] thisName = this.Name.Split(' ');
            int result = thatName.Length > 1 && thisName.Length > 1 ? thisName[1].CompareTo(thatName[1]) : 0;
            if(result == 0)
            {
                result = thisName[0].CompareTo(thatName[0]);
            }
            return result;
        }
    }
}
