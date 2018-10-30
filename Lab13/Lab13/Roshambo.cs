using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    static class Roshambo
    {
        public enum Roshambos
        {
            rock,
            paper,
            scissors
        }

        private static System.Random _random = new System.Random();

        public static Roshambos NextRoshambo()
        {
            return (Roshambos)_random.Next(0,Enum.GetNames(typeof(Roshambos)).Length);
        }
    }
}
