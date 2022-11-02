using System;
using System.Collections.Generic;

namespace CSE210_02.Game
{
    public class Card
    {
        //ATTRIBUTES
            public int lastCard;
            public int currentCard;
        //CONSTRUCTOR
            public void selectCard(){
                var random = new Random();
                currentCard = (random.Next() % 13) + 1;
                return;
            }
            public void switchCard(){
                lastCard = currentCard;
                return;
            }
        public Card()
        {

        }

        //METHOD
        public void Method()
        {

        }
    }
}