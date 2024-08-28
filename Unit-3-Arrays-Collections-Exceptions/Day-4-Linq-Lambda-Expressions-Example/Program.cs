using System;                       // give me access to C# system
using System.Collections.Generic;   // Give me access to C# Collections Stuff
using System.Linq;                  // Give me access to LINQ

namespace Day_4_Linq_Lambda_Expressions_Example
{
    internal class Program
    {
        static List<string> starFleetPersonnel = new List<string>();
        
        // data defined outside of any method (including main())
        // still inside the class program
        // this way it is available and shared by all methods
        // scope
        //          (instead of passing as a parameter to methods that need access to it)
        // It must be made static bc it's used in static methods like Main()
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Linq/Lambda Expression Demo");
            
            // call a method to load the list that is holding our data
            LoadData();

            WriteSeparatorLine("List of People in our List");

            foreach (string anElement in starFleetPersonnel)
            {
                DisplayLine(anElement);
            }

            WriteSeparatorLine("Find an Entry");

            while (true)
            {
                if (!moreInput())
                {
                    break;
                }

                Console.Write("\nEnter value to search for: ");
                string searchString = Console.ReadLine();

                // search the list for matching elements based on user inputs
                //                      using standard c# coding elements
                //
                //int matchCount = 0;
                //          name-of-current-item in-this-list
                //foreach (string anEntry in starFleetPersonnel)
                //{
                //    if (anEntry.ToLower().Contains(searchString.ToLower()))
                //    {
                //        matchCount++;
                //        DisplayLine(anEntry);
                //    }
                //}

                // search the list for matching elements based on user inputs
                //                using LINQ Where() method
                //
                // Syntax: Where(name-of-curr-item => condition-using-name-of-curr-item)
                //
                // a foreach loop is implied by the Where() 
                //           it will go through the list one item at a time and assign the item
                //                                       to the name to left of the =>
                //
                // the list name is implied from being left of the dot in .Where()

                var matchingEntries = starFleetPersonnel.Where(anEntry => anEntry.ToLower().Contains(searchString.ToLower())); // all done in one loop

                // at this point the matching entries variable hold all entries that match the condition...

                Console.WriteLine(("\n" + matchingEntries.Count()) + " entries found matching \'" + searchString + "\'");

                // Loop through the result and display the entries 
                foreach (string aPerson in matchingEntries)
                {
                    DisplayLine(aPerson);
                }

                
            } // end of while loop for searching for lines
            // Display the item in the list that matches a user specified value

            // define a variable to hold what the user wants 
            Console.WriteLine("Please enter the value of want you me to search for: ");
            string whatTheyWant = Console.ReadLine();

            // Use the LINQ First() method to search the list for the first occurence of what they want
            var theFirstOne = starFleetPersonnel.First(aLine =>.Contains(whatTheyWant));

            Console.WriteLine($"\nThe first occurance of {whatTheyWant} is in: {theFirstOne}");


            // First() or Defualt() will always work

            Console.WriteLine("\n" + matchingEntries.Count() + " entries found matching \'" + searchString + "\'");
            Console.WriteLine("\nThanks for trying out the Linq/Lambda Expression Demo");
            PauseProgram();

        } // End of Main()

        /************************************************************************************
         * Load List with sample data
         ************************************************************************************/
        static public void LoadData()
        {
            starFleetPersonnel.Add("James T Kirk, Captain, NCC-1701");
            starFleetPersonnel.Add("Jean Luc Picard, Captain, NCC-1701-D");
            starFleetPersonnel.Add("Jonathan Archer, Captain, NX-1");
            starFleetPersonnel.Add("Catherine Janeway, Captain, NCC-74656");
            starFleetPersonnel.Add("Benjamin Sisco, Captain, DS9");
            starFleetPersonnel.Add("Worf Son of Mogh, Lieutenant, NCC-1701-D");
            starFleetPersonnel.Add("Miles O'Brian, Senior Chief, Deep Space 9");
            starFleetPersonnel.Add("Kira Nerys, Colonel, Deep Space 9");
            starFleetPersonnel.Add("Jadzi Dax, Lt. Commander, Deep Space 9");
            starFleetPersonnel.Add("Odo, Constable, Deep Space 9");
            starFleetPersonnel.Add("Montgomery Scott, Commander, NCC-1701");
            starFleetPersonnel.Add("S'chn T'gai Spock, Commander, NCC-1701");
            starFleetPersonnel.Add("Leonard McCoy,Lt Commander, NCC-1701");
            starFleetPersonnel.Add("Nyota Uhura, Lt Commander, NCC-1701");
            starFleetPersonnel.Add("Deanna Troi, Lt Commander, NCC-1701-D");
            starFleetPersonnel.Add("B'lanna Torres, Lt Commander, NCC-74656");
            starFleetPersonnel.Add("Chakotay, Lt Commander, NCC-74656");
            starFleetPersonnel.Add("Seven of Nine,None, NCC-74656");
            starFleetPersonnel.Add("Tuvok, Lieutenant, NCC-74656");
        } // End of LoadData()

        /************************************************************************************
         * Parse entry in List into individual values
         ************************************************************************************/
        static public void Parse(string staffInfo, out string name, out string rank, out string assignment)
        {
            string[] elements = staffInfo.Split(',');

            name = elements[0];
            rank = elements[1];
            assignment = elements[2];

        } // End of Parse()

        /************************************************************************************
         * Display a separator line block with a message
         ************************************************************************************/
        static void WriteSeparatorLine(string message)
        {
            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("----- " + message);
            Console.WriteLine("-------------------------------------\n");

        } // End of WriteSeparatorLine()

        /************************************************************************************
         * Display a line from the list parsed into individual values
         ************************************************************************************/
        static void DisplayLine(string theLine)
        {
            Parse(theLine, out string personName, out string rank, out string stationed);
            Console.WriteLine($"\nName:\t{personName}\nCrew:\t{stationed}\nRank:\t{rank}");

        } // End of DisplayLine()

        /************************************************************************************
         * Pause program until user presses the enter key
         ***********************************************************************************/
        static void PauseProgram()
        {
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        } // End of PauseProgram()

        /************************************************************************************
         * return a boolean value to indicate if the user has more input
         ************************************************************************************/
        static bool moreInput()
        {
            bool isThereInput = false;  // Hold teh return value 

            string whatUserTyped = "";     // Hold what the user enters

            bool getInput = true;   // Control the user interaction loop

            do
            {
                // Ask the user if they have any numbers to enter (Y/N)
                Console.WriteLine("\nDo you have any values to enter (Y/N)?");
                whatUserTyped = Console.ReadLine();

                whatUserTyped = whatUserTyped.ToUpper();

                string firstChar = whatUserTyped.Substring(0, 1);

                if (firstChar == "Y")
                {
                    getInput = false;
                    isThereInput = true;
                }
                else
                {
                    if (firstChar == "N")
                    {
                        getInput = false;
                        isThereInput = false;
                    }
                }
            } while (getInput); // Loop while we get input

            return isThereInput;

        }  // End of moreInput()

    } // End of class Program
} // End of namespace
