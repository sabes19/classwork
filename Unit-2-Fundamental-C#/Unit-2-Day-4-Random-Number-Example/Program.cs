using System;

/***************************************************************************************************
 * Example use of the Random object
 * 
 * To generate a random number we use a random object
 * 
 * 1. Define a random object
 * 2. Use .Next() method on the random object
 * 
 * You may specify the range inwhich you want the random number generated
 * 
 *      .Next(value) - generate a random number between 0 the value-1
 * 
 *      .Next(start, end) - generate a random number between start and the end01
 * 
 **************************************************************************************************/
namespace Unit_2_Day_4_Random_Number_Example
{
    internal class Program
    {
    static void Main(string[] args)
    {
        // Create a random number generator
        Random random = new Random();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("\n-------- Interation #" + (i+1) + "--------");

            // Generate a random integer between 0 and 99
            int randomNumber = random.Next(100);

            Console.WriteLine("Random number: " + randomNumber);

    // Generate a random number between 1 and 2 (simulating a coin toss)
            // could use this example in deliverable 1 at the beginning of the bootcamp
            int coinToss = random.Next(1, 3);

            // Use the conditional operator (ternary operator) to decide if number is heads or tails
            //
            // 1 == "Heads"
            // 2 == "Tails"
            //
            // Conditional Operator provides a conditional value
            //
            //      (condition) ? value-if-true : value-if-false
            //
            // Replacement for if else statement

            Console.WriteLine("Coin toss: " + ((coinToss == 1) ? "Heads" : "Tails"));
            //
            //
      /***************************************************************************
          * if done with an if-else
             
                if(coinToss ==1)
                    {
                        Console.WriteLine("Coin Toss: Heads"
                    }
                    else
                    {
                        Console.WriteLine("Coin Toss: Tails"
                    }

            *************************************************************************/
             

            // Generate a random double between 0.0 and 1.0
            double randomDouble = random.NextDouble();
            Console.WriteLine("Random double:           " + randomDouble);

            // the .ToString(pattern) - can format a double value with decimal 
            //                          for Display only
            //                          the value in the variable does not change
            //                          IS DISPLAY ONLY - will change the displayed value
            Console.WriteLine("Random double (rounded): " + randomDouble.ToString("0.000"));
        }

        Console.WriteLine("\nPress enter to end program...");
        Console.Read();

        }
    }
}


