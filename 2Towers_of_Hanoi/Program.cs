using System;
using System.Collections.Generic;
using System.Linq;

namespace Towers_of_Hanoi //with Dictionary
{
    class MainClass
    {
        static Dictionary<String, Stack<int>> towers = new Dictionary<string, Stack<int>>();

        public static void Main(string[] args)
        {
            #region Create the initial Board
            //Create the 3 towers(use int stacks) Push 4 elements to the first stack. using Dictionary
            towers.Add("A", new Stack<int>());
            towers.Add("B", new Stack<int>());
            towers.Add("C", new Stack<int>());
            for (int i = 4; i > 0; i--)
            {
                towers["A"].Push(i);
            }

            #endregion
            //PLAYING THE GAME //
            //Check for a winner by using the count in the stack.....stackCount = 4.  While Stack B or Stack C isn't = 4.
            while (towers["B"].Count != 4 && towers["C"].Count != 4)
            {
                PrintBoard();//Reprint the board after each move(call the create function)
                GameMove();
            }

            Console.ReadLine();
        }


        #region Moves of the Game
        public static void GameMove()
        {
            //Function to move from one tower to another; ask user which tower they want to move to and use push and pop to make that happen.
            Console.WriteLine(); //Blank line for formatting
            Console.WriteLine("Which tower do you want to move from?");
            string fromStack = Console.ReadLine().ToUpper();
            Console.WriteLine("Which tower do you want to move to?");
            string toStack = Console.ReadLine().ToUpper();
            if(MoveLegal(fromStack, toStack))
            {
                //Move to the toStack
                towers[toStack].Push(towers[fromStack].Peek());
                towers[fromStack].Pop();
         
            }
            //for each move, need to remove from current stack and add to new stack 
            
        }
        #endregion
        #region Printing the board
        public static void PrintStack(Stack<int> stack) //This is a method to print the stack in the correct order but will not affect the way that the pop works.
        {
            int[] arrTower = stack.ToArray();

            for(int j=arrTower.Length-1; j>=0;j--)
            {
                Console.Write(arrTower[j] + " ");
            }
            
        }
        public static void PrintBoard()
        {
            foreach(var key in towers.Keys) //Prints the board
            {
                Console.Write(key + ": ");
                PrintStack(towers[key]);
                Console.WriteLine();
            }
        }
        #endregion

        public static bool MoveLegal(string from, string to)//Check for illegal moves- can't put larger block on a smaller one
        { //Checks for empty stacks; cant move from an empty stack and when the 'to' stack is empty, we don't need to peek
            if (towers[from].Count != 0 && (towers[to].Count == 0 || towers[from].Peek() < towers[to].Peek()))
            {
                return true;
            }
            Console.WriteLine("No stack for you!"); //Seinfeld reference
            Console.WriteLine(); //wanted an extra line for style preference
            return false;
        }

    }
}
