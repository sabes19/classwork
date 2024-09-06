using System;
using GeneralPurposeFunctions;   // Give me access to the GeneralPurposeFunction Code

namespace Day_3_Playing_Card_Example_V2
{
    internal class Program
    {
        // Instantiate a copy of the code in CommonlyUsedFunctions called myFuncs
        // It's static because its used in Main() which is static
        static CommonlyUsedFunctions myFuncs = new CommonlyUsedFunctions();

        // This is the application program - Main()
        //
        // It will instantiate and manipulate objects of various classes

        static void Main(string[] args)
        {
            myFuncs.WriteSeparatorLine("Welcome to our first OOP Example");

            /*************************************************************************
             * Define/Instantiate a PlayingCard - an Ace of Hearts which is red
             *************************************************************************/
            myFuncs.WriteSeparatorLine("Instantiate and display a PlayingCard");

            //      data-type  name  = new data-type(initializers)
            PlayingCard aCard = new PlayingCard(1, "Hearts");

            Console.WriteLine($"aCard is: {aCard}");  // Display the PlayingCard
                                                      
             /*************************************************************************
             * Define/Instantiate a new PlayingCard to be the same as aCard
             *     and display them both
            *************************************************************************/

            // PlayingCard newCard = aCard;  // This makes both newCard and aCard point to the same object
            PlayingCard newCard = new PlayingCard(aCard); // Use copy constructor

            Console.WriteLine($"  aCard is: {aCard}");
            Console.WriteLine($"newCard is: {newCard}");

            /*************************************************************************
             * Change the value in newCard to be a two
            *************************************************************************/
            myFuncs.WriteSeparatorLine("Change value in newCard to 2");

            //  newCard.cardValue = 2;   // Cannot access private data in an object
            newCard.CardValue = 2;       // Use property to change the value
            Console.WriteLine($"newCard is: {newCard}");
            Console.WriteLine($"  aCard is: {aCard}");


            /*************************************************************************
            * Try and define a PlayingCard with an invalid Suit (Josh)
            *************************************************************************/
            myFuncs.WriteSeparatorLine("Try and define a PlayingCard with an invalid suit (Josh)");
            PlayingCard card3 = new PlayingCard(3, "Josh");
            Console.WriteLine($" card3 is: {card3}");

            /*************************************************************************
            * Try and define a PlayingCard with an invalid value (42)
            *************************************************************************/
            myFuncs.WriteSeparatorLine("Try and define a PlayingCard with an invalid value (42)");
            PlayingCard card4 = new PlayingCard(42, "Diamond");
            Console.WriteLine($" card4 is: {card4}");

            /*************************************************************************
            * Determine if two cards are equal to each other
            *************************************************************************/
            // create a new card that is a copy of aCard
            PlayingCard card5 = new PlayingCard(aCard); // use a copy contstructor

            // display the 2 cards
            Console.WriteLine($" aCard is: {aCard}");
            Console.WriteLine($" card5 is: {card5}");

            if (aCard== card5)
            {
                Console.WriteLine("The cards ARE equal!");
            }
            else
            {
                Console.WriteLine("The cards are NOT equal");
            }
            // We need to use the .Equal() methoid to compare the content of the object
            if (aCard.Equals(card5)) 
            {
                Console.WriteLine("The cards ARE equal!");
            }
            else
            {
                Console.WriteLine("The cards are NOT equal");
            }

            /*************************************************************************
            * Display the HashCodes of two equal objects
            *************************************************************************/
            myFuncs.WriteSeparatorLine("Display the HashCodes of two equal objects");
            Console.WriteLine($"")



            myFuncs.WriteSeparatorLine("Thanks for trying out our first OOP application!");
            myFuncs.PauseProgram();
        }
    }
}
