using System;


namespace test
{
    internal class Program
    {
        static void Main()
        {
            // ask for the users age
            Console.WriteLine("Please enter your age: ");
            string input = Console.ReadLine();

            // validate the age falls within a set range
            if (int.TryParse(input, out int age))
            {
                if (age < 0 || age > 100)
                {
                    Console.WriteLine("Invalid age entered. Please enter a valid age between 0 and 100.");
                }
                else if (age >= 21)
                {
                    Console.WriteLine("You are legally allowed to drink.");
                }
                else
                {
                    Console.WriteLine("You are not legally allowed to drink.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number for age.");
            }
        }
    }
}

