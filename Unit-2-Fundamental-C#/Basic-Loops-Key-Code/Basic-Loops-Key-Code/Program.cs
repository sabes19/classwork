using System;

namespace Basic_Loops_Key_Code
{
    internal class Program
    {
        static void Main()
        {
            // key code combination
            const string correctCombination = "13579";

            // use a boolean to rep if the door is locked
            bool isLocked = true;

            string userCode;

            // While the door is locked, keep asking for code
            while (isLocked)
            {
                Console.Write("Please enter the key code: ");
                userCode = Console.ReadLine();
                if (userCode == correctCombination)
                {
                    isLocked = false;   // Unlock the door
                    Console.WriteLine("The door is now unlocked!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect Code. Please Try Again.");
                }
            }
        }
    }
}