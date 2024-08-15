using System;

namespace Day_5_Method_Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to my app!"); // Verify the app started

            // set up a loop to get 5 numbers, one at a time
            for (int i = 0; i < 5; i++)
            {

                // call the method to get a numeric value
                double aValue = getANumber();

                // display the value we got from the method
                Console.WriteLine("Number entered was: " + aValue);
            }
            Console.WriteLine("\nNumber entered was: "); // verify the app ended
        } // END OF MAIN METHOD
        /*********************************************
        * Helper methods used by Main()
        *********************************************/

        // Method starts with a method signiture: Return-type name(parameters)

        // This method will get a numeric value from the user
        // It must be static because it will be used by the static method Main() (more later)
        // this method receives no parameters and returns a double (a double can also hold an int value)
        static double getANumber()
        {
            // define a variable for the return value
            double theValue = 0;

            // ask the user for a numerica value and have them keep trying until we get one

            bool isValidNumber = false; // determine is user entered a valid value

            // loop until we get a valid numeric value
            do
            {


                // prompt the user to enter a numeric value
                Console.Write("Please enter a number");

                // get the input from the user
                string userInput = Console.ReadLine();

                try
                {
                    // convert the user input to a double as it is a decimal
                    theValue = double.Parse(userInput); // could cause an exception
                    isValidNumber = true; // if .Parse() worked we have a valid number
                }
                catch (FormatException exceptionBlock)  // handle a FormatException in previous try block
                {
                    Console.WriteLine("\n----- Uh-oh Uh-oh Uh-oh ------");
                    Console.WriteLine("there is a problem with " + userInput);
                    Console.WriteLine(exceptionBlock.Message);  // Display the system message for the error
                    Console.WriteLine("----- Uh-oh Uh-oh Uh-oh ------\n");
                }
            } while (isValidNumber); // loop while we dont have a valid number
            // return the double value from the user input
            return theValue;
           

            // 1. figure out steps in solution - programming
            // 2. write this in c# - coding
        }       
    } // END OF CLASS PROGRAM
} // END OF NAMESPACE
// END OF ALL CODE