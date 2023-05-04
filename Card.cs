using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magnemi.DeckOfCardsApp
{
    public class Card
    {
        private String _rank = null;
        private String _suit = null;

        public Card() { }

        public bool set_suit(String s)
        {
            String[] validSuits = { "Hearts", "Diamonds", "Clubs", "Spades" };

            for (int count = 0; count < validSuits.Length; count++)
            {
                if (s == validSuits[count])
                {
                    _suit = s;
                    return true;
                }
            }
            return false;
        }

        public String get_suit()
        {

            if (_suit != null)
            {
                return _suit;
            }
            else
            {
                return "Invalid Suit";
            }
        }

        public bool set_rank(String s)
        {
            String[] validRanks = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };

            for (int count = 0; count < validRanks.Length; count++)
            {
                if (s == validRanks[count])
                {
                    _rank = s;
                    return true;
                }
            }
            return false;
        }

        public String get_rank()
        {
            if (_rank != null)
            {
                return _rank;
            }
            else
            {
                return "Invalid Rank";
            }
        }

        public void displayCard()
        {
            Console.WriteLine("Rank: " + get_rank() + " Suit: " + get_suit());
        }
    }
}