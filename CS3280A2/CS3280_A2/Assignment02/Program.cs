//Benjamin Medrano
// CS 3280
// Assignment 02 
// 6/8/20

using System;
using System.Collections.Generic;
using System.Linq;
namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tName Organizer");

            var fullNames = new List<string>(); // The (first and last) name of each entered person.
            var sortChoice = "";
            var reversedNames = new List<string>();
            var incomplete = true;
            string currentNameInput = "";           

            Console.WriteLine("Enter 5 People's first and last names EX: Joe Dirt");

            insertNames(fullNames, currentNameInput);

            //Sort the names by first or last
            sortByUserChoice(incomplete,sortChoice,fullNames,reversedNames);
               
            Console.WriteLine("Thank you for using my program!");

            Console.ReadKey();
            
        }

        #region
        public static void insertNames(List<string> fullNames, string currentNameInput)
        {
            
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Name " + (i + 1) + ": ");
                currentNameInput = Console.ReadLine();

                //Logic to check if name is used
                if (fullNames.Contains(currentNameInput))
                {
                    Console.WriteLine("Please enter a new name");
                    --i;
                }
                else
                {
                    fullNames.Add(currentNameInput);
                }
            }
        }
        #endregion

        #region
        public static void sortByUserChoice(bool incomplete, string sortChoice, List<string> fullNames, List<string> reversedNames)
        {
            const string choiceFirst = "first";
            const string choiceLast = "last";

            while (incomplete)
            {
                Console.Write("Would you like to sort these names by first or last names? ");
                sortChoice = Console.ReadLine();

                if (sortChoice.Equals(choiceFirst))
                {
                    fullNames.Sort();

                    foreach (string name in fullNames)
                    {
                        Console.WriteLine(name);
                    }
                    incomplete = false;

                }
                else if (sortChoice.Equals(choiceLast))
                {
                    foreach (string name in fullNames)
                    {
                        var lastName = name.Split(' ').Last();
                        var firstName = name.Split(' ').First();
                        reversedNames.Add(lastName + ", " + firstName);

                    }

                    incomplete = false;
                    reversedNames.Sort();

                    foreach (string name in reversedNames)
                    {
                        Console.WriteLine(name);
                    }

                }
                else
                {
                    Console.WriteLine("Please enter a valid order type.");
                }

            }
        }
        #endregion

    }



}
