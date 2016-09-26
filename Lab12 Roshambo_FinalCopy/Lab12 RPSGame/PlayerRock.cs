using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_RPSGame
{
   public class PlayerRock:Player
    {
        public override string generateRoshambo()
        {
            Console.WriteLine ("\nYour opponent threw " + EnumRoshambo.rock.ToString());

            return EnumRoshambo.rock.ToString();
        }
    }
}

