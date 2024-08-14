using System;

namespace Basic_Loops_Key_Code_Do_While
{
    internal class Program
    {
        static void Main()
        {
            const string correctCode = "13579";
            bool isLocked = true;

            do
            {
                Console.WriteLine("Please enter the Combination: ");
                string enteredCombination = Console.ReadLine();

                if (enteredCombination ==  correctCode)
                {
                    isLocked = false;
                    Console.WriteLine("The Door is now unlocked!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect Code. Please try again.");
                    Console.ReadLine();
                }
            } while (isLocked);
        }
    }
}
