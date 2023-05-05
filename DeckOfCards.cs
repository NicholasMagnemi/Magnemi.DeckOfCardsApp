using Magnemi.DeckOfCards;

namespace Magnemi.DeckOfCardsApp
{
    public class DeckOfCards
    {
        private Card[] _deck;

        public DeckOfCards()
        {
            ShuffleDeck shuffler = new ShuffleDeck();
            InputOutput inputOutput = new InputOutput();

            set_deck();

            String message = "Show filled deck in order: \n\n";
            inputOutput.displayMessage(message + displayDeckOfCards());

            shuffler.set_shuffledDeck(_deck);

            message = "Show shuffled deck: \n\n";
            inputOutput.displayMessage(message + shuffler.get_shuffledDeck());

        }

        public bool set_deck()
        {
            _deck = fillDeckWithCards();

            return true;
        }
        public Card[] get_deck()
        {
            return _deck;
        }

        public Card[] fillDeckWithCards()
        {
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] ranks = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };

            Card[] deck = new Card[52];
            int count = 0;

            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    Card card = new Card();
                    card.set_rank(rank);
                    card.set_suit(suit);
                    deck[count++] = card;
                }
            }
            return deck;
        }

        public String displayDeckOfCards()
        {
            String deckOfCards = "";
            for (int count = 0; count < 52; count++)
            {
                deckOfCards += _deck[count].get_rank() + " of " + _deck[count].get_suit() + "\n";
            }
            return deckOfCards;
        }

    }
}