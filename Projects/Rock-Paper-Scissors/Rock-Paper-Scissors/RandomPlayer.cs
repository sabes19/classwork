using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    public class RandomPlayer : Player
    {
        public RandomPlayer(string name, Roshambo.RoshamboValues choice) : base(name, choice) { }   

        public override Roshambo.RoshamboValues GetRoshambo()
        {
            Random randomNum = new Random();
            int randomChoice = randomNum.Next(1, 4); // generate a random number between 1 and 3
            switch (randomChoice)
            {
                case 1: return Roshambo.RoshamboValues.Rock;
                case 2: return Roshambo.RoshamboValues.Paper;
                case 3: return Roshambo.RoshamboValues.Scissors;
                default: return Roshambo.RoshamboValues.Rock;
            
            }
            return (Roshambo.RoshamboValues) randomChoice;


        }
    }
}
