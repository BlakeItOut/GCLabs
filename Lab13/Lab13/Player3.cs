using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Player3 : Player2
    {
        public override string Name { get; set; } = "TheFuzz";
        Random _random = new Random();
        public override Roshambo.Roshambos GenerateRoshambo()
        {
            if (Program._winnersLosers.Count() < 2)
            {
                return base.GenerateRoshambo();
            }
            else
            {
                Roshambo = (Roshambo.Roshambos)(((int)Program._userChoices[_random.Next(Program._userChoices.Count()-2, Program._userChoices.Count())] + 1)%3);
                return Roshambo;
            }
        }
    }
}
