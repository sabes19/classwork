using GeneralPurposeFunctions;
namespace Day_3_File_IO
{
    internal class Program
    {
        private static CommonlyUsedFunctions _myFuncs = new CommonlyUsedFunctions();

        static void Main(string[] args)
        {
            _myFuncs.WriteSeparatorLine("Welcome to a File I/O Example");

            // Display the current execution folder (folder app is running from)
            // The enviorment object gives yuou access to information about the current exedcution enviorment
            Console.WriteLine($"Current Execution Folder is: {Environment.CurrentDirectory}");

            // Display all the lines in the file numbers.txt in files folder/directory

            // Define a StreamReader for the file path containing the file
            // the files path is 3-levels up from our execution path
            // ../ means to go up 1 level

            // StreamReader allen = new StreamReader("../../../files/numbers.txt");

            // Define a running total outside the loop
            int runningTotal = 0;
            try
            {
                using (StreamReader allen = new StreamReader("../../../files/numbers.txt"))

                    // Loop until all the lines have been processed (not EndOfStream)
                    while (!allen.EndOfStream)  // .EndOfStream will indicate when the file is empty (no more data)
                    {
                        //      Get a line from the file
                        string line = allen.ReadLine();

                        // Display and sum the numbers
                        string[] theValues = line.Split(","); // Split line up into values

                        int sum = 0; // reset the sum before we start adding all the numbers

                        for (int i = 0; i < theValues.Length; i++)          // Loop through the values
                        {

                            string aValue = theValues[i].Trim();            // Trim any leading or trailing spaces from the value
                            int intValue = int.Parse(aValue);               // Convert a value from string to int
                                                                            //  int intValue = int.Parse(theValues[i].Trim());  // Alternate to two statements above

                            sum += intValue;                                // add the int value to a sum

                            runningTotal += sum;                            // add the sum to running total

                            Console.WriteLine($"Value #{i}: {aValue}");     // Display the value
                        }

                        // After processing all the numbers

                        Console.WriteLine($"Sum is: {sum}");
                        Console.WriteLine($"Running subtotal: {runningTotal}");

                        // Display the line
                        Console.WriteLine(line);
                        allen.Close();

                    }



                // Close the file when done to free up memory used to support the files

                StreamWriter.Close();
                _myFuncs.PauseProgram();
                _myFuncs.WriteSeparatorLine("Thanks for visiting a File I/O Example");
            }
        }
    }
}
