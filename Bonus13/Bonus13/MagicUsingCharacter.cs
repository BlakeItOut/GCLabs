using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus13
{
    class MagicUsingCharacter : GameCharacter
    {
        public int MagicalEnergy { protected get; set; } = SingleRandom.Instance.Next(0,100);
        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Magical Energy: {MagicalEnergy}");
        }
    }
}
