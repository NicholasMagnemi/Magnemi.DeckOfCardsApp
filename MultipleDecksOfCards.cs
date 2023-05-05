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
            while (!set_multipleDecksOfCards(inputOutput.readUserInput(message))) // Keep asking for input until it's valid
            {
                inputOutput.displayMessage("Invalid input. Please enter a valid number.");
            }

            inputOutput.displayMessage("Here are the decks unshuffled together: \n\n" + get_multipleDecksOfCards());
            inputOutput.displayMessage("Here are the decks shuffled together: \n\n");

            for (int count = 0; count < _multipleDecksOfCards.Length; count++)
            {
                shuffler.set_shuffledDeck(_multipleDecksOfCards[count].get_deck());

                inputOutput.displayMessage(shuffler.get_shuffledDeck() + "\n\n");
            }
            
        }


        public bool set_multipleDecksOfCards(String s)
        {
            InputValidator validNumber = new InputValidator();

            DeckOfCards OneDeck = new DeckOfCards();
            int theAmountOfDecksOfCards;

            if (validNumber.stringToInt(s) == true)
            {
                theAmountOfDecksOfCards = Convert.ToInt32(s);

                _multipleDecksOfCards = new DeckOfCards[theAmountOfDecksOfCards]; // Initialize the array with the correct length

                for (int count = 0; count < theAmountOfDecksOfCards; count++)
                {
                    _multipleDecksOfCards[count] = new DeckOfCards();
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
                multipleDecksOfCards += _multipleDecksOfCards[count].displayDeckOfCards();
            }

            return multipleDecksOfCards;
        }

        public void displayMultipleDecksOfCards()
        {
            throw new System.NotImplementedException();
        }
    }
}