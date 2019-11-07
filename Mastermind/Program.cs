using System;

namespace Mastermind
{
    class MainClass
    {
        static void Main(string[] args)
        {
            var game = new MasterMind();
            game.Play();
            //Console.ReadLine();
        }

    }
    class MasterMind
    {
        //The program should select 2 colors at random from(Red, Yellow and Blue). The colors can repeat.
        private string[] colors = { "red", "yellow", "blue" };
        private string _color1;
        private string _color2;
        //The program should then prompt the user for their guess.
        #region Initialize Game
        private void _initGame()
        {
            //pick 2 randoms
            Random generator = new Random();
            // creates a number 0,1 or 2
            int index1 = generator.Next(0, 3);
            Console.WriteLine();
            int index2 = generator.Next(0, 3);
            _color1 = colors[index1];
            _color2 = colors[index2];
            //
        }
        #endregion
        #region Playing the game
        public void Play()
        {
            int guessLimit = 0;

            //while guess isnt right and limit not reached
            while (guessLimit < 6)
            {

                //ask for guess
                Console.WriteLine("I have chosen 2 of the following colors:  Red, Yellow, or Blue.");
                Console.WriteLine("Write your guess with a space between.");
                //check for guess
                if (CheckGuess(Console.ReadLine().ToLower()))
                {
                    Console.WriteLine("You win!");

                    break;
                }
                else
                {
                    guessLimit++;
                }
                

                //if correct, gameover
                //
            }
        }
        #endregion
        #region Determine a winner
        private bool CheckGuess(string userGuess)
        {
            var ColorsCorrect = 0;
            var PositionCorrect = 0;
            //figure if userguess matches
            if (userGuess.Contains(_color1))
            {
                ColorsCorrect++;
            }
            if (userGuess.Contains(_color2))
            {
                ColorsCorrect++;
            }

            

            //figure out if in correct position use string array to match index
            string[] arrGuess = userGuess.Split(' ');
            if(arrGuess[0] == _color1)
            {
                PositionCorrect++;
            }
            if (arrGuess[1] == _color2)
            {
                PositionCorrect++;
            }

            if(ColorsCorrect == 2 && PositionCorrect == 2)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Your hint is " + ColorsCorrect + "-" + PositionCorrect);
                return false;
            }

        }
        #endregion
        //Constructor runs the init game method
        public MasterMind()
        {
            _initGame();

        }



    }
}
