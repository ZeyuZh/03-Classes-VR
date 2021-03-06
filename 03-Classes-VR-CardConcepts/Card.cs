﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes_VR_CardConcepts
{

    // enumerations of the Suits and Counts that a playing card can have:
    public enum Suit { Spades, Hearts, Diamonds, Clubs };
    public enum Count { Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King };

    // class for constructing a playing card
    public class Card
    {
        public readonly Count count;
        public readonly Suit suit;

        public Card(Count a, Suit b) { count = a; suit = b; }

        // returns the int value of a card in Blackjack
        public int BJvalue()
        {
            int i = (int)count + 1;
            if (i > 10) { i = 10; }
            return i;
        }

        // returns the string value of a card
        public override string ToString() { return count + " of " + suit; }
    }
}
