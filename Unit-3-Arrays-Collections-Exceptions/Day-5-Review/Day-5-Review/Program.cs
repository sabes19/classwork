using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Day_5_Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Store student test scores in an array
            // When you create an array you have to ask yourself -
            // data type? How many value? 

            // instead of using :
            // double score1 = 4;
            // double score2 = 5;
            // double score3 = 6;
            // double score4 = 7;

            // store a students test scores in an array
            // ask: data type? double; how many test scores? (max)? 6
            // double [] testscores = new int[6]; 

            // assign values to each element somewhere in the code

            //         double[] testScores = { 4, 5, 6, 7, 8, 9 };

            // alternate style FOR WHEN YOU DONT KNOW INITINAL VALUES
            double[] testScores = new double[6];


            for (int i = 0; i < testScores.Length; i++)
            {
                testScores[i] = i * 10;
            }
            //
            //      assign values to each element somewhere in the code

            // to catch any exception that might occur in a code
            // use try/catch block

            // try
            //      {
            //      Code that might throw an exception
            //      }
            //  catch (exception-processs name-for-exception-block)
            //      {
            //  handle the exception
            //          display a message
            //          display the data causing the error if available
            //          fix the error so process can continue
            //          throw another exception
            //          whatever you need to do when an exception occurs
            //      }
            //  Code following the true the last catch bloick is executed after the catch block or if there was no execution
            //
            //  catch an exception caused by the code that accessess the array
            try
            {
                Console.WriteLine($"Test score #3 is: {testScores[2]}");
                Console.WriteLine($"Test score #5 is: {testScores[4]}");
                Console.WriteLine($"Test score #1 is: {testScores[0]}");
                Console.WriteLine($"Test score #7 is: {testScores[6]}"); // exception
            }
            catch (Exception exceptionInfo) // if any exceptions happens
            {
                //notify the user
                Console.WriteLine("!!!! Error has occured");
                // Display the message from the system for the exception
                Console.WriteLine(exceptionInfo.Message);
            }
            catch (Exception exceptionInfo)
            {
                // notify the user
                Console.WriteLine("!!! Error has occurred!!!!")
            }




            Console.WriteLine("Please press enter.");
            Console.ReadLine();




            /*************************************************************************************/

            Console.WriteLine("\n -----List example");
            //
            // A kust us a set values all same data type (like an array)
            // UNLIKE an array, a list can be variable size
            //           its size not get bigger or smaller as you execute code

            // More flexible than an array

            // TO DEFINE A LIST

            // List<element-data-element> name = new List<element-data-type>();

            // to add elements to a list: listName.Add(value-to-add);

            // define a list to hold new score
            List<double> Scores = new List<double>();






            ListInitExpression.Grade100())



        }
    }
}
