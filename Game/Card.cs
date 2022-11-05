using System;

namespace CSE210_02.Game
{
    // Card object acts like a new card being drawn from a deck.
    public class Card
    {
        //ATTRIBUTES
        public int _value;
        
        //CONSTRUCTOR
        // When a new card is instantiated, it calls the selectCard method.
        public Card()
        {
            selectCard();
        }

        //METHODS
        // Assigns a random value between 1 and 13 to this instance of the card object.
        private void selectCard()
        {
            var random = new Random();
            _value = random.Next(1, 14);
            return;
        }
    }
}