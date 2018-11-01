using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Student : Person
    {
        private string _program;
        private int _year;
        private double _fee;
        public string Program
        {
            get
            {
                return _program;
            }
        }
        public int Year
        {
            get
            {
                return _year;
            }
        }
        public double Fee
        {
            get
            {
                return _fee;
            }
        }
        public Student ()
        {

        }
        public Student (string name, string address, string program, int year, double fee) : base(name, address)
        {
            _program = program;
            _year = year;
            _fee = fee;
        }
        public override string ToString()
        {
            return base.ToString()+$" ,program={_program}, year={_year}, fee={_fee}";
        }
    }
}
