using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Player2 : Player
    {
        public override string Name { get; set; } = "TheSharks";
        public override Roshambo.Roshambos Roshambo { get; set; }
        public override Roshambo.Roshambos GenerateRoshambo()
        {
            Roshambo = Lab13.Roshambo.NextRoshambo();
            return Roshambo;
        }
    }
}
