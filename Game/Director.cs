using System;
using Game.Card;

namespace CSE210_02.Game
{
    public class Director
    {
        //ATTRIBUTES
        // keeps track of inputs and the score in the game. 
        // runs the loop and calls the functions for gam play

        bool _isPlaying = true;
        int _guess = 0;
        int _score = 0;
        int _totalScore = 0;

        //CONSTRUCTOR
        public Director()
        {
            
        }

        public void startGame()
        {
            while (_isPLaying)
            {
                // outputCard();
                getInputHL();
                updateCard();
                getInputPlaying();
            }
        }

        public void getInputPlaying()
        {
            //Ask user to keep playing or not
            Console.Write("Continue playing? [y,n] ");
            keepPlaying = Console.ReadLine();
            _isPlaying = (keepPlaying == "y");

            
        }

        public void getInputHL()
        {
            //Ask user for their guess
            Console.Write("what is your guess?  ");
            string guess = Console.ReadLine();
            _guess = Convert.ToInt32(guess);
        }

        public void updateCard()
        {
            if (!_isPlaying)
            {
                return;
            }

            //update card and score

        }

        public void doOutputs()
        {
            
        }
    }
}
