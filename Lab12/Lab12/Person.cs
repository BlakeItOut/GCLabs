using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Person
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
            return $"Person[name={_name}, address={_address}]";
        }
    }
}
