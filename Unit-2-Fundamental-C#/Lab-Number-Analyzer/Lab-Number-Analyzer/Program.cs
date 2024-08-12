using System;

namespace Lab_Number_Analyzer
{
    internal class Program
    {
        static void Main()
        {
            // Ask for user name
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            // Main loop to keep prompting the user for input
            while (true)
            {
                // Prompt the user to enter an integer between 1 and 100
                Console.Write($"{userName}, please enter an integer between 1 and 100: ");
                string input = Console.ReadLine();

                // Validate input
                if (int.TryParse(input, out int number) && number >= 1 && number <= 100)
                {
                    // Conditional statements to determine the output based on the input
                    if (number % 2 != 0)
                    {
                        if (number < 60)
                        {
                            Console.WriteLine($"{number} is Odd and less than 60.");
                        }
                        else
                        {
                            Console.WriteLine($"{number} is Odd and greater than 60.");
                        }
                    }
                    else
                    {
                        if (number >= 2 && number <= 24)
                        {
                            Console.WriteLine($"{number} is Even and less than 25.");
                        }
                        else if (number >= 26 && number <= 60)
                        {
                            Console.WriteLine($"{number} is Even and between 26 and 60 inclusive.");
                        }
                        else if (number > 60)
                        {
                            Console.WriteLine($"{number} is Even and greater than 60.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer between 1 and 100.");
                }

                // Ask the user if they want to continue
                Console.Write($"{userName}, do you want to try again? (yes to continue, any other key to exit): ");
                string response = Console.ReadLine();
                if (response != "yes")
                {
                    break;
                }
            }

            Console.WriteLine("Thank you for using the application. Goodbye!");
        }
    }
}