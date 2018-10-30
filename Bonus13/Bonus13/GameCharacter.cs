using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus13
{
    class GameCharacter
    {
        public string Name { get; set; }
        public virtual int Strength { get; set; } = SingleRandom.Instance.Next(0, 50);
        public virtual int Intelligence { get; set; } = SingleRandom.Instance.Next(0, 50);

        public virtual void Play ()
        {
            Console.WriteLine($"\n{getImage(SingleRandom.Instance.Next(0,characters.Length))}\n\nName: {Name}\nStrength: {Strength}\nIntelligence: {Intelligence}");
        }

        public string getImage(int item)
        {
            return characters[item];
        }

        public virtual string[] characters { get; set; } =
        {
            @"                        .-------,
                     ../         \
                    /  ,   ,   ,  \
                   /  , \__\___\   \      
                  |   | __ || __',. \     
                  |   \_'_/ \_'_/.   |    
                  |  (|    v    |)   |    ---   -----
                  ,    |       |    .       /
                   |    \  ~  /     |   ---'
                   |   /. | | .\    .
                   / ,/ |/   \| \,  |,
                  ( <-,  \___/  ,->   )
                   |  ,_ \   / _,  .|
                   | \  \ \ / /   / |
                   | |   \ * /    | |
                   | |     #      | |",
            @"                           _______________________
                           \_____________________/
                            \       __O__       /
                             \      =(_)=      /              +
            +                _\  ___________  /_         .  . . .
             . . +          ( \\/ ___   ___.\// )       +.. .. .+
             .. .. :         \    (o)) ((o)    /       ... .. . .
            .. : .. .:. .    (_)    /   \    (_)      ..+.. + ...+
            . .+ . ++. .       \:. (_   _) .:/         +  + :.. + :
             . __... . +        )::::\_/::::(            :. __  . .
             _(  \ __ .        (:::\_|_|_/:::)          __ /  )_
            (  \  (  \      __  \:::\_|_/:::/  __      /  )  /  )
             \  \  \  \    /  )  \:::::::::/  (  \    /  /  /  /
            ( \  \  \  \__/  /    |\:::::/|    \  \__/  /  /  //)
             \ \_ \_ \_     / ____| |___| |____ \     _/ _/ _/ /
              \            /_/ ||   |___|   || \_\            /
               \          /\   ||  (_____)  ||   /\          /
                \________/ \\  ||___________||  // \________/
   ______________\\_______//    |___________|   \\______//_________________
                  \______/_:                   :_\______/
"
        };
    }
}
