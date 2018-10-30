using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Player3 : Player2
    {
        Random _random = new Random();
        public override Roshambo.Roshambos GenerateRoshambo()
        {
            if (Program._winnersLosers.Count() < 5)
            {
                return base.GenerateRoshambo();
            }
            else
            {
                return (Roshambo.Roshambos)(((int)Program._userChoices[_random.Next(0, Program._userChoices.Count())] + 1)%3);
            }
        }
    }
}
