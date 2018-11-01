using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Person : IComparable<Person>
    {
        private string _name;
        private string _address;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }
        public Person ()
        {

        }
        public Person (string name, string address)
        {
            _name = name;
            _address = address;
        }
        public override string ToString()
        {
            return $"type={this.GetType().ToString().Split('.')[1]}, name={_name}, address={_address}";
        }
        public int CompareTo(Person that)
        {
            string[] thatName = that.Name.Split(' ');
            string[] thisName = this.Name.Split(' ');
            int result = thisName[0].CompareTo(thatName[0]);
            if (result == 0)
            {
                result = thisName[1].CompareTo(thatName[1]);
            }
            return result;
        }
    }
}
