using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{

    // this is a subclass of the player class
    // always throws rock
    // does not have a user supplied name
    public class RockPlayer : Player // : means subclass of player
    
    // no need for ctor that takes any arguments
    // we do need a defualt ctor since values are constant (never change)
    
    {
        public RockPlayer() : base("TheRock", Roshambo.RoshamboValues.Rock) { }


        
        

        public abstract Roshambo.RoshamboValues GenerateRoshambo()
        {
            return Roshambo.RoshamboValues.Rock;
        }
    }
}
