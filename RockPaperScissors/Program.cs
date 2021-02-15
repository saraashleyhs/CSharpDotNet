using System;
using static System.Console;

namespace RockPaperScissors
{
    class MainClass
    {
        static int userCounter;
        static int compCounter;
        static int gameCounter;
        public static void Main(string[] args)
        {
            while (gameCounter < 5)
            {
                Game();

            }
            WriteLine(compCounter);
            WriteLine(userCounter);
            if (userCounter > compCounter)
            {
                WriteLine("You have won the big prize!");
            }
            else
            {
                WriteLine("Sorry you lost to a computer!");
            }
        }

        public static void Game()
        {
            WriteLine("Rock, Paper, Scissors, Shoot!");
            WriteLine("What is your choice?");
            string userChoice = ReadLine().ToLower(); //put this into the variable to compare
            Random generator = new Random();  // creates a number 0,1 or 2
            int randomNumber = generator.Next(0, 3);
            string computer = "";
            if (randomNumber == 0)
            {
                computer = "rock";
                WriteLine("The computer chose " + computer);
            }
            else if (randomNumber == 1)
            {
                computer = "paper";
                WriteLine("The computer chose " + computer);
            }
            else 
            {   
                computer = "scissors";
                WriteLine("The computer chose " + computer);
            }
            string result = CompareHands(userChoice, computer);
            Console.WriteLine(result);

        }
       static String CompareHands(String hand1, String hand2)  //compare user respone to computer choice
        { //make a variable called winning hand
            string ret = "";
            gameCounter++;
            if (hand1 == hand2)
            {
                ret = "This is a tie.";
            }
            else if (hand1 == "rock")
            {
                if(hand2 == "paper")
                {
                    ret = "Computer wins!";
                    compCounter++;
                }
                else if(hand2 == "scissors")
                {
                    ret = "You win!";
                    userCounter++; 
                }
            }
            else if (hand1 == "paper")
            {
                if (hand2 == "scissors")
                {
                    ret = "Computer wins!";
                    compCounter++;
                }
                else if (hand2 == "rock")
                {
                    ret = "You win!";
                    userCounter++; 
                }
            }
            else if (hand1 == "scissors")
            {
                if (hand2 == "rock")
                {
                    ret = "Computer wins!";
                    compCounter++;
                }
                else if (hand2 == "paper")
                {
                    ret = "You win!";
                    userCounter++; 
                }
            }
            else
            {
                ret = "Invalid entry";
                gameCounter--;
            }
            return ret;

        }
    }
}
