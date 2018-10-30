using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    abstract class Player
    {
        public abstract string Name { get; set; }
        public abstract Roshambo.Roshambos Roshambo { get; set; }
        public abstract Roshambo.Roshambos GenerateRoshambo();
    }
}
