using System;
using GeneralPurposeFunctions; // gives me access to general purpose function code

namespace Day_2_Playing_Card_Example
{
    internal class Program
    {
            // Instatiate a cop[y of the code in CommonlyUsedFunctions
            //          Called myFuncs
            // static bc its used in Main() which is static
        static CommonlyUsedFunctions myFuncs = new CommonlyUsedFunctions();

        // this is the application program
        // 
        // It will instantiate and manipulate objects of various classes

        static void Main(string[] args)
        {
            myFuncs.WriteSeparatorLine("Welcome to our first OOP Example!");


            /**********************************************************************
            * Define/Instantiate a PlayingCard - an Ace of Hearts (red)
            **********************************************************************/
            myFuncs.WriteSeparatorLine("Instantiate and display a PlayingCard");

        //  data type   name  = new data type  (initializers)
            PlayingCard aCard = new PlayingCard(1, "Hearts", "Red");

            Console.WriteLine($"aCard is: {aCard}"); // display the PlayingCard

            //      WHY 2-STRING METHOD IS REQUIRED
            // Console.WriteLine expects a string to be written
            // interpolation ($"") - generates a string
            // aCard is aPlayingCard type not a string
            // in order for it to be written it needs to be converted to a string
            // The default ToString() method to convert an object to a string generates
            //              a string containing the "namesspace.className"
            // If you want your class objects to be represented as a string,
            //      you must override the defualt ToString() method in your class
            // i.e. YOU decide what a string representation of your class looks like


            /**********************************************************************
            * Define/Instantiate a PlayingCard to be the same as aCard
            *   and display them both
            **********************************************************************/



            //  PlayingCard newCard = aCard; // this makes both newCard and aCard point to the same object
            PlayingCard newCard = new PlayingCard(aCard); // use copy constructor

            Console.WriteLine($"  aCard is: {aCard}");
            Console.WriteLine($"newCard is: {newCard}");


            /**********************************************************************
            * Change the value in newCard to be a two 
            **********************************************************************/
            myFuncs.WriteSeparatorLine("Change value in newCard to 2");
        //  newCard.cardValue;  // cannot access private data in an object
            newCard.CardValue = 2; // Use Property to change the value
            Console.WriteLine($"newCard is: {newCard}");


            myFuncs.PauseProgram();
        }
    }
}
