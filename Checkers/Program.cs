using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkers
{
    class Program
    {
        public static void Main(String[] args)
        {
            Game game = new Game();
            game.Start();
        }
    }
    public struct Position
    {
        public int Row { get; private set; }
        public int Col { get; private set; }
        public Position(int row, int col)//have to pass parameters b/c a struct can't have a default constructor without parameters.
        {
            Row = row;
            Col = col;
        }
    }

    public enum Color
    {
        White, Black
    }
    #region Checker Class
    public class Checker
    {
        public String Symbol { get; private set; }
        public Color Team { get; private set; }
        public Position Position { get; set; }

        public Checker(Color team, int row, int col)
        {
            if (team == Color.White)
            {
                int openCircleId = int.Parse("25CB", System.Globalization.NumberStyles.HexNumber);
                string openCircle = char.ConvertFromUtf32(openCircleId);

                Console.WriteLine(openCircle);
            }
            else
            {
                int closedCircleId = int.Parse("25CF", System.Globalization.NumberStyles.HexNumber);
                string closedCircle = char.ConvertFromUtf32(closedCircleId);

                Console.WriteLine(closedCircle);
            }
        }

    }
    #endregion
    #region Board Class
    public class Board
    {
        public List<Checker> checkers;
        public Board() //Constructor:initializing the board
        {
            checkers = new List<Checker>();
            for (int r = 0; r < 3; r++)
            {
                for (int i = 0; i < 8; i += 2)//skipping a space to place a checker
                {
                    Checker c = new Checker(Color.White, r, (r + 1) % 2 + i);//instantiating a new checker object for each position
                    checkers.Add(c);
                }
                for (int i = 0; i < 8; i += 2)//skipping a space to place a checker
                {
                    Checker c = new Checker(Color.Black, 5 + r, (r) % 2 + i);
                    checkers.Add(c);
                }
            }
        }

        public Checker GetChecker(Position pos)
        {
            ///TODO:  Use linq to implement this function
            foreach (Checker c in checkers)
            {
                if (c.Position.Row == pos.Row && c.Position.Col == pos.Col)
                    return c;
            }
            return null;
        }

        public void RemoveChecker(Checker checker)
        {
            // ...
            if(checker!=null)
            {
                checkers.Remove(checker);
            }
            ///TODO what if null?
        }

        public void MoveChecker(Checker checker, Position dest)
        {
            // ..make a new checker in the dest position and remove the 
            Checker c = new Checker(checker.Team, dest.Row, dest.Col);
            checkers.Add(c);
            RemoveChecker(checker);
        }

    }
    #endregion
    #region Game Class
    public class Game
    {
        private Board board;
        public Game()
        {
            this.board = new Board();
        }

        private bool CheckForWin()
        {
            return (board.checkers.All(x => x.Team == Color.White) || board.checkers.All(x => x.Team == Color.Black));

            ///TODO what if its a draw?
        }

        public void Start()
        {
            // ...
        }

        public bool IsLegalMove(Color player, Position src, Position dest)//most complicated function
        {
            //1 Out of bounds check
            if (src.Row < 0 || src.Row > 7 || src.Col < 0 || src.Col > 7 || dest.Row < 0 || dest.Row > 7 || dest.Col < 0 || dest.Col > 7)
            {
                return false;
            }
            //2 Checking for slope and distance 
            int rowDistance = Math.Abs(dest.Row - src.Row);
            int colDistance = Math.Abs(dest.Col - src.Col);
            if (colDistance == 0 || rowDistance == 0) return false;
            if (rowDistance / colDistance != 1) return false;

            //3 Checking for row distance being less than or equal to 2
            if (rowDistance > 2) return false;

            Checker c = board.GetChecker(src);
            if (c == null) return false;

            Checker d = board.GetChecker(dest);
            if (d != null) return false;

            if (rowDistance == 2)
            {
                if (IsCapture(player, src, dest) == true)
                {
                    return true;
                }
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool IsCapture(Color player, Position src, Position dest)
        {
            int rowDistance = Math.Abs(dest.Row - src.Row);
            int colDistance = Math.Abs(dest.Col - src.Col);
            if (rowDistance == 2 && colDistance == 2)
            { //checks if there is a checker in the middle.
                int row_Mid = (dest.Row + src.Row) / 2;
                int col_Mid = (dest.Col + src.Col) / 2;
                Position p = new Position(row_Mid, col_Mid);
                Checker c = board.GetChecker(p);
                if (c == null)
                {
                    return false;
                }
                else
                {
                    if (c.Team != player)
                    {
                        return true;
                    }
                    return false;
                }
            }
            return true;
        }

        public Checker GetCaptureChecker(Color player, Position src, Position dest)
        {
            // ..
            if (IsCapture(player, src, dest) == true)
            {
                int row_Mid = (dest.Row + src.Row) / 2;
                int col_Mid = (dest.Col + src.Col) / 2;
                Position p = new Position(row_Mid, col_Mid);
                Checker c = board.GetChecker(p);
                return c;
            }
                return null;

        }

        public Position ProcessInput() //behind the scenes stuff of the game.  Where do you want to move...then the computer processes whether the move is  legal, where to move it, remove if necessary, switch players here.
        {
            // ...
        }

        public void DrawBoard()
        {
            String[][] grid = new String[8][];
            for (int r = 0; r < 8; r++)
            {
                grid[r] = new String[8];
                for (int c = 0; c < 8; c++)
                {
                    grid[r][c] = " ";
                }
            }
            foreach (Checker c in board.checkers)
            {
                grid[c.Position.Row][c.Position.Col] = c.Symbol;
            }

            Console.WriteLine("  0  1  2  3  4  5  6  7");
            Console.WriteLine(" ");
            for (int r = 0; r < 8; r++)
            {
                Console.Write(r);
                for (int c = 0; c < 8; c++)
                {
                    Console.Write($" {grid[r][c]} \u2503");
                }
                Console.WriteLine();
            }
            for(int i = 0; i<32;i++)
            {
                Console.Write("\u2501");
            }
        }


    }
    #endregion

}