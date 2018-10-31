using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    public interface ICountable
    {
        void IncrementCount();
        void ResetCount();
        int GetCount();
        string GetCountString();
    }
}
