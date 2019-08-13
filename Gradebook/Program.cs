using System;
using System.Collections.Generic;
using System.Linq;

namespace Gradebook
{
    class MainClass
    {
        static string userChoice;
        public static void Main(string[] args)
        {
            Dictionary<string, string> Gradebook = new Dictionary<string, string>();
            //create a dictionary for name and grades.
            //Your program should ask the user to enter a student name, or "quit"

            //Steps 1, 2 and 3 should be repeated until the user enters quit for the students name. (WHILE LOOP)
            Console.WriteLine("Enter a student's full name or type finished");
            userChoice = Console.ReadLine().ToLower();
            while (userChoice != "finished")
            {//If the user enters a students name, your program should then ask the user to enter the students grades as single string separated by spaces("100 90 78 101 45 81")
                Console.WriteLine("Enter each assignment grade separated by a space");
                string studentGrades = Console.ReadLine();
                //Add the name and the grades (as a single String) to a dictionary(Dictionary<String,String>)
                Gradebook.Add(userChoice, studentGrades);
                Console.WriteLine("Enter a student's full name or type finished");
                userChoice = Console.ReadLine().ToLower();
            }

            //Your program should then loop through the entries in the dictionary, and print out the name of the student, their lowest, highest and average grade.

            int lowestGrade;
            int highestGrade;
            double averageGrade; //create variables for lowest, highest, and average

            foreach (string key in Gradebook.Keys)
            {
                Console.WriteLine($"Name: {key}");
                Console.WriteLine($"Grades: {Gradebook[key]}");
                //Convert the single string representing the grades into an array or list of strings.
                // To convert a grade from a String to an int, you can use Convert.ToInt32(String)
                int[] SingleGrades;
                SingleGrades = Array.ConvertAll<string, int>(Gradebook[key].Split(), Convert.ToInt32);
                //Finding the lowest, highest and average
                lowestGrade = SingleGrades.Min();
                highestGrade = SingleGrades.Max();
                averageGrade = SingleGrades.Average();
                Console.WriteLine(key + " ");
                Console.WriteLine(key + "'s lowest grade is: " + lowestGrade);
                Console.WriteLine(key + "'s highest grade is: " + highestGrade);
                Console.WriteLine(key + "'s average grade is: " + averageGrade);
            }
        }
    }
}

