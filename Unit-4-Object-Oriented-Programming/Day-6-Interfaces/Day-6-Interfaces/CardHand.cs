using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Interfaces
{
    // interface for behaviors/methods a Class wanting to be a CardHand must implement

    // Interfaces have
    //      1. no data
    //      2. method signitures of the methods they require
    //
    // a method signiture: returnType name(parameters);

    // 
    internal interface ICardHand
    {
        // Draw a card (add a card to the hand)
        void AddCard(PlayingCard cardToAdd);



        // Discard a card (remove a card from the hand)
        void RemoveCard(PlayingCard cardToRemove);



        // Organize cards based on some critaeria (values, suit, color, what makes you feel lucky)
        void SortHand(string howToSort);



        // Throw the hand in (folding, clear the hand of cards)
        void ThrowHand();



        // Show itself (display the value, color, suit of all cards in the hand)
        void ShowHand();
    }
}
