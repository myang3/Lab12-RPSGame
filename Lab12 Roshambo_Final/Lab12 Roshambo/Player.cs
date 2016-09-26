using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_Roshambo
{

    public abstract class Player
    {
        string roshamboVal;
        string name;
        public abstract string generateRoshambo();
    }
}
