using System;

namespace Student_Database_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {



            // creating a multi-dimensional array (really just a fun 2-d array, an array of arrays as frank put it)
            // each row is an array of columns

            // in this lab we will create 3 arrays for student information
            // 1. name
            // 2. hometown
            // 3. favorite food

            // show what

            const int ARRAY_SIZE = 5

            string[] studentInfo = new string[5]; // define array of 5 strings

            // define a variable to hold the user input
            string studentNames = " ";

            // variable to hold the sum of numbers
            double theSum = 0;

            // defind variable to number of variable s entered by the user
            int numberEntered = 0;

            // set up a loop to get ARRAY_SIZE numbers, one at a time or responses indicating the user is done
            for (int i=0; i < ARRAY_SIZE; i++)


            // set up the loop to get 5 numbers (one at a time or until response indicates they are done)
            for (int i = 0; i < 5; i++)
            {
                // ask the user to enter their name
                Console.WriteLine("Please enter your name. Enter 'N' to stop.");
                studentNames = Console.ReadLine();

                if (studentNames == "N") // confidtion if...
                {
                    break; // exit the for-loop
                }

                // call the method to get a numeric value
                studentInfo[i] = studentRecords(); // get the number from the user and store in the next array element
            }

            // at this point the array has all the numbers entered by the user

            





        }
    }
}
