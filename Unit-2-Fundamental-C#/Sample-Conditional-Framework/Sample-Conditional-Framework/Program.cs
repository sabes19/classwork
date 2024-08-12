using System;  // give me access to C# system stuff
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_Sample_Conditional_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for an odd number between 11 and 17
            // verify they have entered a correct value


            Console.WriteLine("Please enter an odd number between 11 and 17");
            
            int thenumber = int.Parse(Console.ReadLine()); //  get the user input and convert to the int

            // show the user what we got from them
            Console.WriteLine("You entered:" + thenumber);

            // verify the number is between 11 and 17
            if (thenumber >= 11 && thenumber <= 17)
            {
                Console.WriteLine("The Value IS odd and between 11 and 17")
            }
            else
            {
                       }




            // make VS keep the console window open ntil we are done
            Console.WriteLine("press enter to continue...");
            Console.ReadLine();
        }
    }
}
