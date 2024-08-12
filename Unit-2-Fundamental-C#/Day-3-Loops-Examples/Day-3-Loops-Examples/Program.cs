using System; 


namespace Day_3_Loops_Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ask the user for 3 #s
            // add the numbers up
            // find the avg of the numbers
            // display the 3 numbers, the sum average

            // define variables reused in the loop
            int numberSum = 0; // hold the sum of the numbers
            int anumber   = 0;   // hold a number entered by the user
            int NumNums = int.Parse(Console.ReadLine()); // the nmumber of numbers we want the user to enter

            /*********************



            // ask the user how many numbers they have
            Console.WriteLine("How many numbers do you have to enter?");
            NumNums = int.Parse(Console.ReadLine());

            // Loop through process - three times
            //
            // 1. int i will be set to 0 (initialize)
            // 2. check i < 3 (check condition)
            //    if condition is true - perform the loop process (code between {})
            //    if condition is false - exit the loop
            // 3. increment the int i (i++)
            // 4. go back to step 2
            //
            for (int i=0; i < NumNums; i++) // i will go from 0, 1, 2 inside the loop
            {


                // ask the user for 3 #s
                Console.WriteLine("Please enter a number " + (i+1) + " of " + NumNums);
                anumber = int.Parse(Console.ReadLine());
                // get a line from user and convert to int  - read line only returns string arguments

                

                // add the number to the sum
                numberSum = numberSum + anumber;
            // at this point we have the numbers summed and we have displayed them
            } // end of the loop *********************************/

            /****** Solution using a while-loop *******************************

            // Loop until the user tells us they have no more numbers to enter

            bool shouldLoop = true; // AsyncFlowControl how long wee loop

            while (shouldLoop) // loop while shouldloop is true
            {
                Console.WriteLine("Enter a number or end to finish");
                string userInput = Console.ReadLine();

                // did they type "end"? if so exit set to exit loop
                if (userInput == "end")
                {
                    shouldLoop = false; // set the loop control variable to end the loop
                }
                else
                {
                    NumNums++; // Count the fact a number was entered by the user
                    anumber = double.Parse(userInput);
                        // Convert the data from a string to double
                    numberSum += anumber;   // add a number to the sum variable
                }
            }




            ****** End of while-loop Solution *******************************/

            /****** Solution using a do-while-loop *******************************
            ****** End of do-while-loop Solution *******************************/

            // loop until the user tells us they have no more numbers to enter (typoe end instead of number)

            string userInput = ""; // Hold the data entered by the user

            do
            {
                Console"enter a number or end to finish");
                string userInput = Console.ReadLine();

                if (userInput == "end")
                {
                    continue; // skip to the end of 
                }
            }






            // find the avg of the numbers; Note use of double so we can have decimal places

         double numberaverage = numberSum / NumNums;

            // display the sum average
         Console.WriteLine("The sum is " + numberSum);
         Console.WriteLine("The Avergage is: " + numberaverage);



         // make VS wait to close the console window
         Console.WriteLine("Press Enter to finish.");
         Console.ReadLine();
         }
         }
         }
