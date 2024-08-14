using System;
using System.Runtime.CompilerServices;


namespace Unit_2_Day_4_Switch_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence");
            string theLine = Console.ReadLine();

            AConsole.WriteLine("\nYou entered: \"" + theLine + "\"");

            Console.WriteLine("\nThe line in all lowercase is: ");
            Console.WriteLine(theLine.ToLower());

            Console.WriteLine("\nThe line in all uppercase is: ");
            Console.WriteLine(theLine.ToUpper());

            Console.WriteLine("\nIt contains: \n");

            Console.WriteLine("\t" + theLine.Length + " characters");
                // in the count.Chars method:typeToCount    , sourceText
            Console.WriteLine("\t" + countChars("Consonants", theLine) + " consonants");
            Console.WriteLine("\t" + countChars("Vowels"    , theLine) + " vowels");
            Console.WriteLine("\t" + countChars("Numbers"   , theLine) + " numbers");
            Console.WriteLine("\t" + countChars("Special"   , theLine) + " special characters");

            string[] words = theLine.Split(' ');
            Console.WriteLine("\t" + words.Length + " words");

            /***************************************************************************************
             *           theLine = "Welcome to C#!"
             *             
             *           string[] words = theLine.Split(' ');  // Split the string based on a space
             *
             *   (index) |   [0]   | [1] | [2] |
             *           |---------|-----|-----|
             *     words | Welcome | to  | C#! |
             *           |_________|_____|_____|
             *
             ***************************************************************************************/

            Console.WriteLine("\nThe first letter of each word is: ");

            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i].Substring(0,1) + " ");
            }
            
            PauseProgram();

            Console.WriteLine("Enter a word to search for or enter to not search");
            string searchWord = Console.ReadLine();

            if (searchWord != "")
            {
                bool wordFound = theLine.Contains(searchWord);

                if (wordFound)
                {
                    Console.WriteLine("The word \"" + searchWord + "\" was found!");
                }
                else
                {
                    Console.WriteLine("The word \" " + searchWord + " was NOT found!");
                }
            }
            PauseProgram();
         }

        /******************************************************************************************
         * Helper methods used in Main() processing
         *
         * Note: Methods are static because Main() is static (more later)
         *****************************************************************************************/

        /******************************************************************************************
         * Method to Pause program and wait for enter
         *
         * Receives: no parameters
         *
         * Returns: nothing
         *****************************************************************************************/

        static void PauseProgram()
        {
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }

        /******************************************************************************************
         * Method to count the various types of characters in a string
         *
         * Receives: Two parameters:  1. The type of character count to return
         *                            2. The string to be processed by the method  
         *                           
         * Returns: The count of the number of characters in the string of the type requested
         *****************************************************************************************/

        static int countChars(string typeToCount, string sourceText)
        {
            string textToSearch  = sourceText.ToLower();
            int vowelCount       = 0;
            int consonantCount   = 0;
            int numberCount      = 0;
            int specialCharCount = 0;

            for (int i = 0; i < textToSearch.Length; i++)
            {
                if (textToSearch[i] == 'a'
                    || textToSearch[i] == 'e' // use i to index through the string
                    || textToSearch[i] == 'i' // char literals are placed inside ' ' NOT " "
                    || textToSearch[i] == 'o'
                    || textToSearch[i] == 'u')
                {
                    vowelCount++;
                }
                
                else
                {
                    if (textToSearch[i] >= 'a' && sourceText[i] <= 'z')
                    {
                        consonantCount++;
                    }
                    else
                    {
                        if (textToSearch[i] >= '0' && sourceText[i] <= '9')
                        {
                            numberCount++;
                        }
                        else
                        {
                            if (textToSearch[i] != ' ')
                            {
                                specialCharCount++;
                            }
                        }
                    }
                }
            }
            // return the count requested in the first parameter passed to use 
            switch (typeToCount)
            {
                case "Vowels": // type vowels
                {
                    return vowelCount;
                }
                case "Consonants": // Type consonants
                {
                    return consonantCount;
                }
                case "Numbers":
                {
                    return numberCount;
                }
                case "Special":
                {
                    return specialCharCount;
                }
                default: // if a type you werent expecting was requested...
                {
                    return -1; // return an obviously incorrect value

                }
            }
        }

    }
}
