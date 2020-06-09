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
            string currentNameInput;
            var sortChoice = "";
            var reversedNames = new List<string>();
            var incomplete = true; 
            Console.WriteLine("Enter 5 People's first and last names EX: Joe Dirt");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Name " + (i+1) + ": ");
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

            //Sort the names by first or last
            while (incomplete)
            {
                Console.Write("Would you like to sort these names by first or last names? ");
                sortChoice = Console.ReadLine();

                if (sortChoice.Equals("first"))
                {
                    fullNames.Sort();

                    foreach (string name in fullNames)
                    {
                        Console.WriteLine(name);
                    }
                    incomplete = false;

                }else if (sortChoice.Equals("last"))
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

                }else
                {
                    Console.WriteLine("Please enter a valid order type.");
                }

            }
               

                Console.WriteLine("Thank you for using my program!");

                Console.ReadKey();
            
        }
       
    }



}
