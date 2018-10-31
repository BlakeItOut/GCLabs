using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class Alligator : ICountable
    {
        private int _count = 1;
        public int GetCount()
        {
            return _count;
        }

        public string GetCountString()
        {
            return _count.ToString(); ;
        }

        public void IncrementCount()
        {
            _count++;
        }

        public void ResetCount()
        {
            _count = 1;
        }
        public override string ToString()
        {
            return $"{_count} alligator";
        }
    }
}
