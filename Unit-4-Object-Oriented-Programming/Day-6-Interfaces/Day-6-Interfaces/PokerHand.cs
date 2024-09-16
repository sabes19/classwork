using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Interfaces
{
    // this class represents a 5-card poker hand
    // since it is a type of card hand, we will use the ICardHand interface
    //       to be sure whomever looks at this knows the basic behaviors

    public class PokerHand : ICardHand
    {
        /*****************************************************************
         * Data Members  
         * **************************************************************/
        
        // Define a constant available to anyone for the # of cards in the hand
        public const int NUMBER_CARDS_IN_HAND = 5;

        // Define a reference to an object to hold the cards in the hand
        // Note: use of the base class type - Polymorphism is enabled if we need it
        private List<PlayingCard> theHand;

        /*****************************************************************
         * Method Members
         * **************************************************************/
        // Defualt constrctor
        public PokerHand()
        {
            // Instatiate object data members and assign the object to the reference
            theHand = new List<PlayingCard>();
        }

        // Draw a card(add a card to the hand)
        public void AddCard(PlayingCard cardToAdd)
        {
            theHand.Add(cardToAdd);
        }

        // Discard a card (remove a card from the hand)
        public void RemoveCard(PlayingCard cardToRemove)
        {
            theHand.Remove(cardToRemove);
        }

        // Show itself (display the value, color, suit of all cards in the hand)
        public void ShowHand()
        {
            foreach (PlayingCard card in theHand)
            {
                card.ShowCard();
            }
        }

        // Organize cards based on some critaeria (values, suit, color, what makes you feel lucky)
        public void SortHand(string howToSort)
        {
            //To be done later - logic complex
        }

        // Throw the hand in (folding, clear the hand of cards)
        public void ThrowHand()
        {
            theHand.Clear(); // remove all objects in the list
        }

        // return a card from the hand based on its position (1-1st position)
        PlayingCard GetCardAtPosition(int position)
        { 
            return theHand[position - 1]; // adjust the position passed for 0-based index  
        }
    }
}
