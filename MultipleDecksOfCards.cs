using Magnemi.DeckOfCards;

namespace Magnemi.DeckOfCardsApp
{
    public class MultipleDecksOfCards
    {
        private DeckOfCards[] _multipleDecksOfCards;

        public MultipleDecksOfCards()
        {
            ShuffleDeck shuffler = new ShuffleDeck();
            InputOutput inputOutput = new InputOutput();

            String message = "How Many decks of cards would you like to shuffle together?";
            set_multipleDecksOfCards(inputOutput.readUserInput(message));

            inputOutput.displayMessage("Here are the decks unshuffled together: \n\n" + get_multipleDecksOfCards());
            

        }

        public bool set_multipleDecksOfCards(String s)
        {
            InputValidator validNumber = new InputValidator();
            int theAmountOfDecksOfCards;

            if (validNumber.stringToInt(s) == true) 
            {
                theAmountOfDecksOfCards = Convert.ToInt32(s);

                for (int count = 0; count < theAmountOfDecksOfCards; count++)
                {
                    _multipleDecksOfCards[count].set_deck();
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public String get_multipleDecksOfCards()
        {
            String multipleDecksOfCards = "";

            for (int count = 0; count < _multipleDecksOfCards.Length; count++)
            {
                multipleDecksOfCards = _multipleDecksOfCards[count].get_deck();
            }

            return multipleDecksOfCards;
        }

        public void displayMultipleDecksOfCards()
        {
            throw new System.NotImplementedException();
        }
    }
}