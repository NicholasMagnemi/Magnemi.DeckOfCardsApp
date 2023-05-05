using Magnemi.DeckOfCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magnemi.DeckOfCardsApp
{
    public class ShuffleDeck
    {
        private Card[] _shuffledDeck;

        public ShuffleDeck()
        {

        }
        
        public ShuffleDeck(Card[] unShuffledDeck)
        {
            InputOutput inputOutput = new InputOutput();

            set_shuffledDeck(unShuffledDeck);

            String message = "Show filled deck in order: \n\n";
            inputOutput.displayMessage(message + get_shuffledDeck());
        }

        public bool set_shuffledDeck(Card[] unShuffledDeck)
        {
            if (unShuffledDeck != null)
            {
                _shuffledDeck = shuffler(unShuffledDeck);
                return true;
            }
            else
            {
                return false;
            }
        }

        public String get_shuffledDeck()
        {
            String shuffledDeckOfCards = "";
            
            for (int count = 0; count < 52; count++)
            {
                shuffledDeckOfCards += _shuffledDeck[count].get_rank() + " of " + _shuffledDeck[count].get_suit() + "\n\n";
            }
            return shuffledDeckOfCards;
        }

        public Card[] shuffler(Card[] unShuffledDeck)
        {
            Card[] tempDeck = new Card[unShuffledDeck.Length];

            Random random = new Random();

            for (int count = 0; count < unShuffledDeck.Length; count++)
            {
                int randomIndex = random.Next(0, unShuffledDeck.Length);
                tempDeck[count] = unShuffledDeck[randomIndex];
            }
             return unShuffledDeck = tempDeck;
        }

        public DeckOfCards shuffler(DeckOfCards unShuffledDeck)
        {

        }
}