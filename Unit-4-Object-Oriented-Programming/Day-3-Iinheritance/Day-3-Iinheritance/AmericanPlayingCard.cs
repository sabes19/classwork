using Day_3_Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Iinheritance

// This will be a subclass of PlayingCard.cs
// and will add what an AmericanPlaying card needs that differs from PlayingCard

{
    public class AmericanPlayingCard : PlayingCard // Indicate PlayingCard is our base class
    {
        // NO data in subclass
        // NO methods other than the constuctor

        // We get access to all the data and methods in the base class PlayingCard


        // Create a 0-arg constructor for AmericanPlayingCard

        // Pass all the data to base class constructor
        public AmericanPlayingCard(int theValue, string theSuit, string theColor) : base(theValue, theSuit, theColor)
        {
            // no data in subclass
        }
    
    }
}
