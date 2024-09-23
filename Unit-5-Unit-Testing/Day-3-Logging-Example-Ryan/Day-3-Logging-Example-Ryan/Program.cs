using GeneralPurposeFunctions;
using System.IO.Enumeration;

namespace Day_3_Logging_Example_Ryan
{
    internal class Program
    {
        // by defining this outside any method, it is available to all methods in the class
        // static is required because the methods will be used inside main, which is static
        static CommonlyUsedFunctions myFuncs = new CommonlyUsedFunctions();

        static string inputFilePath = "../../../data/IMDB-Top-25-SciFi-Movies.txt";


        // To avoid trying to define the logFile mroe than once...
        // Make the reference to the file static and outside any method
        //      1. Defines one refernce
        //      2. 

        static StreamWriter logFile = null;                                // Define reference and set to null

        static void Main(string[] args)
        {
            // Log the program start
            LogEvent("Program Started...");


            // Read and display all the data in the IMDB-Top-SciFi-Movies file

            
            StreamReader fileReader = new StreamReader(inputFilePath);              // Define a StreamReader for the file

            
            List<string> sciFiMovies = new List<string>();                          // Define a list to hold each line from the file










            /**********************************************************
            * Lets be sure we can read all the data successfully
            **********************************************************/

            //////////////////////////////////
            //
            //////////////////////////////////

            // while-loop
            while (!fileReader.EndOfStream)                 // loops as long as its not the end of the stream
            {
                string line = fileReader.ReadLine();        // Get a line from the file
                sciFiMovies.Add(line);                      // Add a line to the list
            }

            // Loop until the user indicates they are done by typing 'N' or "No" when asked
            while (myFuncs.moreInput())                      // moreInput() returns true if the user says they have more input...
            {







                // Ask the user which movie they want from the list by partial word search
                // Prompt the user to entert a word to search for
                Console.WriteLine("Please enter a word from the title of the movie you are searching for...");
                // define a place to hold the user response (user's choice)
                string userInput = Console.ReadLine();          // get a word from the user

                // Check to see if any movies in the list contain words
                // loop through the list of movies to see if the title contains the word
                foreach (string aLine in sciFiMovies)
                {
                    if (aLine.Contains(userInput))
                    {
                        LogEvent($"Found title {userInput}");
                        Console.WriteLine(aLine);
                    } // ends the foreach
                } // ends the outer while


                fileReader.Close();                             // Release memory used by supporting data structures
                
                LogEvent("Program Ended...");


                myFuncs.PauseProgram();
            }


        } // ends the Main()

        /*******************************
        // Helper methods for Main()
        ********************************/
        // Method: log program events including user interactions to a disk file
        public static void LogEvent(string messageToLog)
        {
            // To avoid trying to define the logFile more than once...
            


            if (logFile == null)
            {
                // Define the disk file to hold the log
                logFile = new StreamWriter("../../../program.log");
            }
        // Add a timestamp to the log message
        // get the current timestamp as a string
            DateTime currentTimestamp = DateTime.Now;       // get current time stamp
            string formattedTime = currentTimestamp.ToString("yyyy-MM-dd-HH:mm:ss");
            logFile.WriteLine($"{formattedTime} - {messageToLog}");
            logFile.Flush();
        }
    } // ends the class with Main()
} // end the namespace
