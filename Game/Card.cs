using System;

namespace CSE210_02.Game
{
    public class Card
    {
        //ATTRIBUTES
        public int _value;
        
        //CONSTRUCTOR
        public Card()
        {
            selectCard();
        }

        //METHODS
        private void selectCard()
        {
            var random = new Random();
            _value = random.Next(1, 14);
            return;
        }
    }
}