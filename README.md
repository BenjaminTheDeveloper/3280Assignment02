Written By Benjamin Medrano 

# Assignment 02
Description:
This assignment was designed to organize 5 full names by first or last name.



# Variables
            var fullNames = new List<string>(); // The (first and last) name of each entered person.
            string currentNameInput; // used for the current input name
            var sortChoice = ""; //Stores whether the user wants to sort by first or last name. 
            var reversedNames = new List<string>(); // This list holds the fullName list with last names first. 
            var incomplete = true;  //Runs the while loop until it is complete(!incomplete)
# Code
This program utilizes if, else, and while conditions. 
The while loop was written to stop errors from happening when a user enters their sort choice. 

# Methods 
1) 
   public static void insertNames(List<string> fullNames, string currentNameInput);
   Description: This method allows the user to enter 5 names while adding them to the fullNames List. 
   Using the currentNameInput variable, it holds each name entered by the user one at a time before placing it                              into the fullNames List. 
            
2)       
   public static void sortByUserChoice(bool incomplete, string sortChoice, List<string> fullNames, List<string> reversedNames);
   Description: This method prompts the user for a choice. Once the user is prompted the method uses the choice to determine                how it will organize the names. It uses the reverseNames to store last names if the user chooses to order by                            last. Otherwise it will use fullNames to order them by first names. 

# Usage
1) The Name Organizer will prompt you for five names. (Make sure to not repeat a name, it will catch this.)
2) Once you complete entering names, it will then ask if you want first names or last names organized. 
3) Once you choose your sort type (first or last) you can see the results in alphabetic order. 



