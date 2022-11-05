using System;

namespace CSE210_02.Game
{
    // This class acts as the main director for the HILO program.
    // Controls the game loop, input and output for the game.
    public class Director
    {
        //ATTRIBUTES
        // keeps track of inputs and the score in the game. 
        bool _isPlaying = true;
        string _guess = "";
        int _score = 0;
        int _totalScore = 300;
        Card _currentCard = new Card();
        Card _nextCard = new Card();
        

        //CONSTRUCTOR
        public Director()
        {

        }

        //METHODS

        // startGame is called by Main to run the game loop.
        public void startGame()
        {
            while (_isPlaying)
            {
                outputCard();
                getInputHL();
                updates();
                calculatePlaying();
            }
        }

        // Displays the current card value
        private void outputCard()
        {
            int cardValue = _currentCard._value;
            Console.WriteLine($"The card is: {cardValue}");
        }

        // Asks user for their guess of higher or lower
        private void getInputHL()
        {
            //Ask user for their guess
            Console.Write("Higher or lower? [h/l] ");
            _guess = Console.ReadLine();
        }

        // This method will compare the player's guess with the value of the next card,
        // then calculate the score that will be added to the player's total score.
        // It also assigns the next card to the current card object.
        private void updates()
        {
            if (!_isPlaying)
            {
                return;
            }

            //update card and score
            Console.WriteLine($"Next card was: {_nextCard._value}");

            bool correctGuess = false;
            if (_guess == "h")
            {
                correctGuess = (_nextCard._value >= _currentCard._value);
            }
            else if (_guess == "l")
            {
                correctGuess = (_nextCard._value <= _currentCard._value);
            }

            if (correctGuess)
            {
                _score = 100;
            }
            else
            {
                _score = -75;
            }

            _totalScore += _score;

            Console.WriteLine($"Your score is: {_totalScore}");

            _currentCard = _nextCard;
            _nextCard = new Card();
        }

        // Decide whether to continue the game or not.
        private void calculatePlaying()
        {
            if (_totalScore > 0)
            {
                //Ask user to keep playing or not
                Console.Write("Continue playing? [y/n] ");
                string keepPlaying = Console.ReadLine();
                Console.WriteLine();
                _isPlaying = (keepPlaying == "y");
            }
            else
            {
                Console.WriteLine("YOU LOSE, LOSER!!");
                _isPlaying = false;
            }            
        }
    }
}
