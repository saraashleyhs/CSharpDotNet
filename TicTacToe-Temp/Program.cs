using System;

namespace TicTacToeTemp
{
    class MainClass
    {
        public static string playerTurn = "X";
        public static string[][] board = new string[][]
        {
            // 0 First Row  0    1    2
            new string[] {" ", " ", " "},
            // 1 Second Row 0    1    2
            new string[] {" ", " ", " "},
            // 2 Third Row    0    1    2
            new string[] {" ", " ", " "}
        };

        public static void Main()
        {
            do
            {
                DrawBoard();
                GetInput();
                Console.Clear();

            } while (!CheckForWin() && !CheckForTie());

            // leave this command at the end so your program does not close automatically
            DrawBoard();
            Console.ReadLine();
        }

        public static void GetInput()
        {
            Console.WriteLine("Player " + playerTurn);
            Console.WriteLine("Enter Row:");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Column:");
            int column = int.Parse(Console.ReadLine());
            PlaceMark(row-1, column-1);
        }

        public static void PlaceMark(int row, int column)
        {
            // your code goes here
            board[row][column] = playerTurn;
            switchTurn();

        }

        public static void switchTurn()
        {
            if (playerTurn == "X")
            {
                playerTurn = "O";
            }
            else//means playerturn = "O"
            {
                playerTurn = "X";
            }
        }

        public static bool CheckForWin()
        {
            // your code goes here
            if (HorizontalWin() || VerticalWin() || DiagonalWin())
            {
                switchTurn();
                Console.WriteLine(playerTurn + " Won!");
  
                return true;
            }

            return false;
        }

        public static bool CheckForTie()
        {
            int markCount = 0;
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if (board[i][j] != " ")
                    {
                        markCount++;
                    }
                }
            }
            if(markCount == 9 && !CheckForWin())
            {
                return true;
            }
            return false;
        }

        public static bool HorizontalWin()
        {
            for (int i = 0; i < 3; i++)
            {
                //checks horizontal first, then vertical, example: if horizontal match AND none are blank, then winner
                if ((board[i][0] == board[i][1] && board[i][0] == board[i][2]) && (board[i][0] != " "))
                {
                   return true;
                }
            }

            return false;
        }

        public static bool VerticalWin()
        {
            for (int j = 0; j < 3; j++)
            {
                //checks horizontal first, then vertical, example: if horizontal match AND none are blank, then winner
                if ((board[0][j] == board[1][j] && board[0][j] == board[2][j]) && (board[0][j] != " "))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool DiagonalWin()
        {
            if ((board[0][0] == board[1][1] && board[0][0] == board[2][2] && (board[0][0] != " ")) ||
                        ((board[2][0] == board[1][1] && board[2][0] == board[0][2]) && (board[2][0] != " "))) { return true; }

                return false;
        }

        public static void DrawBoard()
        {
            Console.WriteLine("  1 2 3");
            Console.WriteLine("1 " + String.Join("|", board[0]));
            Console.WriteLine("  -----");
            Console.WriteLine("2 " + String.Join("|", board[1]));
            Console.WriteLine("  -----");
            Console.WriteLine("3 " + String.Join("|", board[2]));
        } 
    }
}
