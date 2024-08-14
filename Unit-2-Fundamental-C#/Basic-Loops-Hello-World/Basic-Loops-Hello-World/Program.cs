using System;

namespace Basic_Loops_Hello_World
{
    internal class Program
    {
        static void Main()
        {
            string UserInput;

            do
            {
                // statements
                Console.WriteLine("Hello World!");
                Console.Write("Would you like to Continue?");
                UserInput = Console.ReadLine().Trim().ToLower();
            } while (UserInput == "y");

            Console.WriteLine("Goodbye!");
        }
    }
}
