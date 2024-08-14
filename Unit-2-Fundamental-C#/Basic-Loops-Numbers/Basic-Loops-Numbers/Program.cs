using System;

class Program
{
    static void Main()
    {
        string userInput;

        do
        {
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                // Loop to output numbers from 'number' to 0
                for (int i = number; i >= 0; i--)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();

                // Loop to output numbers from 0 to 'number'
                for (int i = 0; i <= number; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            Console.Write("Would you like to continue (y/n)? ");
            userInput = Console.ReadLine().Trim().ToLower();

        } while (userInput == "y");

        Console.WriteLine("Goodbye!");
    }
}
