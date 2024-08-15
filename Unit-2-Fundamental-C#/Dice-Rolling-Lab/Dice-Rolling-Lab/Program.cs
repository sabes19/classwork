using System;
using System.CodeDom.Compiler;

namespace Dice_Rolling_Lab
{
    internal class Program
    {
        static void Main()
        {
            int sides = 0; // setting the initial value of sides to 0
            bool validInput = false;

            // get the number of sides for the dice // use a while loop
            while (!validInput)
            {
                Console.WriteLine("How many sides does the dice have? ");
                try
                {
                    sides = int.Parse(Console.ReadLine());
                    if (sides < 2)
                    {
                        Console.WriteLine("The dice must have at least 2 sides. Please try again. ");
                    }
                    else
                    {
                        validInput = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            string rollAgain;
            do
            {
                Console.WriteLine("Press Enter to roll the dice). ");
                Console.ReadLine();

                // roll the dice
                int die1 = GenerateRandomNumber(sides);
                int die2 = GenerateRandomNumber(sides);

                // display the results
                Console.WriteLine(String.Format("You rolled: {0} and {1}", die1, die2));
                int total = die1 + die2;
                Console.WriteLine(String.Format("Total: {0}", total));

                // Check for special combinations if 6-sided dice
                if (sides == 6)
                {
                    string specialMessage = CheckSpecialCombinations(die1, die2);
                    if (!string.IsNullOrEmpty(specialMessage))
                    {
                        Console.WriteLine(specialMessage);
                    }
                }
            
            
                // Ask if the user will roll again
                Console.Write("Do you want to roll again? ");
                rollAgain = Console.ReadLine().ToLower();

            } while (rollAgain == "y") ;

            Console.WriteLine("Thank you for Playing!");
        }

        // Method to generate a random number between 1 and the number of sides
        static int GenerateRandomNumber(int sides)
        {
            Random random = new Random();
            return random.Next(1, sides + 1);
        }

        // method to check for special combinations for six sided dice
        static string CheckSpecialCombinations(int die1, int die2)
        {
            int total = die1 + die2;

            if (die1 == 1 && die2 == 1)
            {
                return "snake eyes!";
            }
            if ((die1 == 1 && die2 == 2) || (die1 == 2 && die2 == 1))
            {
                return "Ace Deuce";
            }
            if (die1 == 6 && die2 == 2)
            {
                return "Box Cars!";
            }
            if (total == 7 || total == 11)
            {
                return "Win!";
            }
            if (total == 2 || total == 3 || total == 12)
            {
                return "Craps!";
            }
        }
    }
}