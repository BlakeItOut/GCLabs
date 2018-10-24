using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus13
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                GameCharacter[] gameCharacters =
                {
                    new Warrior(){Name="Blue Warrior",WeaponType="Axe"},
                    new Warrior(){Name="Yellow Warrior",WeaponType="Sword"},
                    new Warrior(){Name="Green Wizard"},
                    new Wizard(){Name="Red Wizard"},
                    new Wizard(){Name="Black Wizard"}
                };
                foreach (GameCharacter gameCharacter in gameCharacters)
                {
                    gameCharacter.Play();
                }
                if (Validator.promptContinue())
                {
                    break;
                }
                Console.Clear();
            }
        }
    }
}
