using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Player1 : Player
    {
        public override string Name { get; set; } = "TheJets";
        public override Roshambo.Roshambos Roshambo { get; set; }
        public override Roshambo.Roshambos GenerateRoshambo()
        {
            Roshambo = Lab13.Roshambo.Roshambos.rock;
            return Roshambo;
        }
    }
}
