using System;
using System.Collections.Generic;

namespace Day_6_Interfaces
{
    /**********************************************************************************************
     * This class represents a 52 card deck of AmericanPlayingCards with optional Jokers
     *********************************************************************************************/
    
    public class CardDeck
    {
        /******************************************************************************************
         * Data Members
         *****************************************************************************************/

        // define a reference to a data memeger object
        private List<AmericanPlayingCard> theDeck; // define reference and instantiate and assign later


        /******************************************************************************************
         * Method Members
         *****************************************************************************************/

        //----------------------------------------------------------------------------------------
        // Constructors
        //----------------------------------------------------------------------------------------

        public CardDeck(bool jokerOption = false)
        {
            // Instantiate data members objects and assign them to their associated reference in ctor
            theDeck = new List<AmericanPlayingCard>();
            InitializeCardDeck(jokerOption);
        }

        //----------------------------------------------------------------------------------------
        // Helper methods - assist the class in it's processing objects of the class
        //----------------------------------------------------------------------------------------

        private void InitializeCardDeck(bool jokerOption)
        {
            // at this point in the process - we have no AmericanPlayingCard objects to use for
            // access to any data or methods we might need in the AmericanPlayingCard class
            // Set up cards with values from 1 to max value
            // Since we have no AmericanPlayingCard objects yet, we can use the class name to access the public constants
            //                                    Class-Name.dataMemberName instead of objectName.dataMemberName
            AmericanPlayingCard aCard = new AmericanPlayingCard();
            // Set up cards with values from 1 to max value
            //                                  Class-Name.Method() instead of objectName.method()
                        for (int i = 1; i <= AmericanPlayingCard.MAX_CARD_VALUE; i++)
            {
                // set up a card fpr each suuit (except joker) with the current value
                // get array of the suit value from the class
                //                                  Class-Name.Method() instead of objectName.method()
                foreach (string aSuit in AmericanPlayingCard.GetSuits())
                {
                    if (aSuit == "Joker")
                    {
                        continue;
                    }
                   theDeck.Add(new AmericanPlayingCard(i, aSuit));
                }
            }
            if (jokerOption) // if they want jokers to add two jokers to the botttom of the deck
            {
                theDeck.Add(new AmericanPlayingCard(AmericanPlayingCard.DEFAULT_CARD_VALUE, AmericanPlayingCard.DEFAULT_SUIT));
                theDeck.Add(new AmericanPlayingCard(AmericanPlayingCard.DEFAULT_CARD_VALUE, AmericanPlayingCard.DEFAULT_SUIT));
            }

        }
        //----------------------------------------------------------------------------------------
        // Access methods - Allow users to access and manipulate objects of the class
        //----------------------------------------------------------------------------------------
        public void ShowDeck()
        {
            foreach(AmericanPlayingCard aCard in theDeck)
            {
                aCard.ShowCard();
            }
        }

        public AmericanPlayingCard DealACard()
        {
            if (theDeck.Count == 0) // if deck is empty...
            {
                return null;        // ...return the null
            }

            AmericanPlayingCard cardDealt = theDeck[0]; // if not empty, get the top card and hold it
            theDeck.RemoveAt(0);                        // remove top card from deck
            return cardDealt;                           // return the top card we are holding
        }

        public int Count()          // return the number of 
        {
            return theDeck.Count;
        }

        // Shuffle a card deck
        //  Loop through the deck. On each iteration, swap the current card with a randomly chosen one.
        public void Shuffle()
        {
            Random randomCardLocation = new Random();

            //  Loop through the deck from the end to the beginning
            //  On each iteration, swap the current card with a randomly chosen one.
            for (int currentCard = theDeck.Count - 1; currentCard > 0; --currentCard)
            {
                int swapCard = randomCardLocation.Next(currentCard + 1); // get random index for swap card
                AmericanPlayingCard heldCard = theDeck[currentCard];     // Remember the current card
                theDeck[currentCard]         = theDeck[swapCard];        // Replace current card with swap card
                theDeck[swapCard]            = heldCard;                 // Replace swap card with prior current card
            }
        }
    }
}