using System;
using System.Collections.Generic;

namespace TicTacToe
{
    class MainClass
    {
        static int moveCounter = 0;
        static Dictionary<string, int> gameCheck = new Dictionary<string, int>();
        static bool GameDone;
        static bool xPlayer = true;
        static char[,] board = new char[3, 3];
        public static void Main()
        {
            gameCheck.Add("D1", 0);
            gameCheck.Add("D2", 0);
            for (int x = 1; x <= 3; x++)
            {
                gameCheck.Add("R" + x, 0);
            }
            for (int y = 1; y <= 3; y++)
            {
                gameCheck.Add("C" + y, 0);
            }
            ClearBoard();
            while (GameDone == false)
            {
                PrintBoard();
                PlaceMarker();
                CheckWinner();
                xPlayer = !xPlayer;
            }
        }
        #region Print the board
        public static void PrintBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("-------");

                for (int j = 0; j < 3; j++)
                {
                    Console.Write("|" + board[i, j].ToString());
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("-------");
        }
        #endregion
        #region  Playing the Game
        public static void PlaceMarker()
        {
            Console.WriteLine("Give me the row number:");
            int row = Int32.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Give me the column number:");
            int col = Int32.Parse(Console.ReadLine()) - 1;
            if (xPlayer)
            {
                board[row, col] = 'x';
                moveCounter++;
            }
            else
            {
                board[row, col] = 'o';
                moveCounter++;
            }
        }
        #endregion
        #region Check Winner
        public static void CheckWinner()
        {
            for (int x = 1; x <= 3; x++)
            {
                for (int y = 1; y <= 3; y++)
                {
                    if (board[x-1, y-1] == 'x')
                    {
                        gameCheck["R" + y]++;
                        gameCheck["C" + x]++;
                    }
                    else if (board[x-1, y-1] == 'o')
                    {
                        gameCheck["R" + y]--;
                        gameCheck["C" + x]--;
                    }
                }
            }
            foreach (string key in gameCheck.Keys)
            {
                if (gameCheck[key] == 3)
                {
                    Console.WriteLine("The Game is over! Player X wins!");
                    GameDone = true;
                }
                else if (gameCheck[key] == -3)
                {
                    Console.WriteLine("The Game is over! Player O wins!");
                    GameDone = true;
                }
            }
        }
            #endregion
            #region Clear the board 
            public static void ClearBoard()
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        board[i, j] = ' ';
                    }
                }
            }
            #endregion
        }
    }



