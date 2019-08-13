using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperHeroes
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            var list = new CreateList();
            list.create();
            list.PrintPeople();
        }
    }

    class CreateList //using this class to run methods for creating the list.
    {
        //create a few average humans, villains, and superheroes. Add them to a list of human (List<Person>). After adding all instances to the list, loop through them and print each one's name followed by the greeting:
        //"William: Hi, my name is William, you can call me Bill."
        //"Mr Incredible: I am Wade Turner. When I am Mr. Incredible, my super power is Super Strength!"
        //"The Joker: I am The Joker! Have you seen Batman?"
        //Dictionary<string, List<Person>> FullPeopleList = new Dictionary<string, List<Person>>();
        static List<Person> GetPeople = new List<Person>();
        public void create()
        {
            GetPeople.Add(new Person("Martin", "Marty"));
            GetPeople.Add(new SuperHero("Superman", "Clark Kent", "Superman stuff"));
            GetPeople.Add(new Villian("Lex Luther", "Superman"));


            //Console.Write("Please tell us who you are or type 'stop'.  ");
            //Console.WriteLine("Are you a superhero, villian, or normal person?");

            // while (Console.ReadLine().ToLower() != "stop")
            /*{
                //Add the people to the list. Not sure what needs to go here.
				if(Console.ReadLine().ToLower() 
				GetPeople.Add(new Person(//Parameters//));
            }*/

        }
        public void PrintPeople()
        {
            foreach (Person person in GetPeople)
            {
                //run PrintGreeting on the list
                person.PrintGreeting();
            }
        }
    }

    //Create a Person class, that has the following fields - Name, NickName
    class Person
    {
        public virtual string Name { get; set; }
        public string NickName { get; set; }

        //Your Person class should override the ToString() method, and return the persons name.
        public override string ToString()
        {
            return Name;
        }
        //Your Person class should have a PrintGreeting() method, that prints a greeting of the form "Hi, my name is William, you can call me Bill."
        public virtual void PrintGreeting()
        {
            Console.WriteLine("Hi, my name is {0}, but you can call me {1}.", Name, NickName);
        }



        public Person(string name, string nickName) //Your Person class should have a constructor that accepts the name and nickname.
        {
            Name = name;
            NickName = nickName;
        }
    }



    //Create a SuperHero class that extends Person.Your SuperHero class should have the following fields- RealName, SuperPower
    class SuperHero : Person
    {
        public override string Name { get; set; }
        public string RealName { get; set; }
        public string SuperPower { get; set; }

        //Your SuperHero class should have a constructor that takes in the name, real name, and super power of the superhero.And should pass null to the base constructor for the nickname. (Superheroes do not have nick names)
        public SuperHero(string Name, string realName, string superPower) : base(Name, null)
        {
            RealName = realName;
            SuperPower = superPower;
        }

        //Your SuperHero class should override the PrintGreeting() method.It should print a message of the form "I am Wade Turner. When I am Mr. Incredible, my super power is Super Strength!"
        public override void PrintGreeting()
        {
            Console.WriteLine("I am {0}. When I am {1}, my super power is {2}.", RealName, Name, SuperPower);
        }
    }

    //      Villain
    //Create a Villain class that extends Person. Your Villain class should have the following field
    //Nemesis
    class Villian : Person
    {
        public override string Name { get; set; }
        public string Nemesis { get; set; }

        //Your Villain class should have a constructor that takes in the name and nemesis of the villain.And should pass null to the base constructor for the nickname.
        public Villian(string name, string nemesis) : base(name, null)
        {
            Nemesis = nemesis;
        }


        //Your Villain class should override the PrintGreeting() method.It should print a message in the form of "I am The Joker! Have you seen Batman?"
        public override void PrintGreeting()
        {
            Console.WriteLine("I am {0}. Have you seen {1}?", Name, Nemesis);
        }
    }
}
