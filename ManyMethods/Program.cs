using System;

namespace ManyMethods
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Hello();
            //Addition();
            //CatDog();
            //OddEven();
            //Inches();
            //Echo();
            //KillGrams();
            //Date();
            //Age();
            Guess();


        }
        public static void Hello() //Prints out a greeting and ask the user their name.Then responds with a "Bye Bob!" (replacing Bob with the name entered)
        {
            Console.WriteLine("Howdy!");
            Console.WriteLine("What is your name?");
            string Name = Console.ReadLine();
            Console.WriteLine("Bye " + Name);
        }

        public static void Addition() // A method that ask the user for 2 numbers and prints out their sum
        {
            Console.WriteLine("What is your first number?");
            int num1 = int.Parse(Console.ReadLine()); // converts string to int
            Console.WriteLine("What is your second number?");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum is " + (num1 + num2)); //can do int sum on separate line
        }

        public static void CatDog() // A method that ask the user if they prefer cats or dogs, and either "Barks" or "Meows" back depending on what theyentered
        {
            Console.WriteLine("Do you like cats or dogs?");
            string Pref = Console.ReadLine();
            if (Pref == "cats" || Pref == "cat")
            {
                Console.WriteLine("Meow!");
            }
            if (Pref == "dogs" || Pref == "dog")
            {
                Console.WriteLine("Bark!");
            }
        }
        public static void OddEven() //A method that asks the user for a number, and prints out if it is odd or even
        {
            Console.WriteLine("Give me a number.");
            int num3 = int.Parse(Console.ReadLine());
            if (num3 % 2 == 1)
            {
                Console.WriteLine("Your number is odd!");
            }
            else
            {
                Console.WriteLine("Your number is even!");
            }

        }

        public static void Inches()// A method that ask the user for a height in feet and returns the height converted to inches
        {
            Console.WriteLine("Enter your height in feet:");
            float inch = float.Parse(Console.ReadLine());
            Console.WriteLine(inch * 12);
        }

        public static void Echo() //A method that ask the user for a word then prints it 3 times, first in all caps, then 2 more time in all lower case
        {
            Console.WriteLine("Enter any word:");
            string word = Console.ReadLine();
            Console.WriteLine(word.ToUpper());
            Console.WriteLine(word.ToLower());
            Console.WriteLine(word.ToLower());
        }
        public static void KillGrams()// A method that ask the user for a weight in pounds, then converts it to killograms
        {
            Console.WriteLine("Enter your weight in pounds:");
            float weight = float.Parse(Console.ReadLine());
            Console.WriteLine("Your weight in kg is " + weight / 2.205);
        }
        static void Date() //A method that prints out the current date
        {

            DateTime today = DateTime.Now;
            Console.WriteLine("Today's date is " + today.ToString("dddd, MMMM dd yyyy"));

        }

        public static void Age() //A method that asks the user their birth year, and print out their age
        {
            Console.WriteLine("What year were you born?");
            int ageYear = int.Parse(Console.ReadLine());
            int currentYear = int.Parse(DateTime.Now.Year.ToString());
            Console.WriteLine("You are " + (currentYear - ageYear) + " years old.");
        }

        public static void Guess()// A method that ask the user to guess a word, and print out 'CORRECT!!' if the word is "chsarp", otherwise prints out 'WRONG!!'
        {
            Console.WriteLine("Guess my word.");
            string answer = Console.ReadLine();
            int guesses = 0;
            while (guesses < 10)
            {
                if (answer.ToLower() == "csharp" || answer == "Csharp")
                {
                    Console.WriteLine("Correct! You win!");
                    guesses = 10;
                }
                else
                {
                    Console.WriteLine("Incorrect, Please try again");
                    answer = Console.ReadLine();
                    guesses++;
                }

            }
            
        }

    }
}

