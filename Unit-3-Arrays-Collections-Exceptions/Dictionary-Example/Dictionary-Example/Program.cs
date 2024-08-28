using System;
using System.Collections.Generic; // gives me access to the system .... 

namespace Dictionary_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*********************************
             * Example use of a Dictionary
             * ******************************/



            // Create a dictionaryt for relating zip codes people live in

            // data-type<key-type, value-type> name = new Dictionary<key-type, value>();
            Dictionary<string, int> personInfo = new Dictionary<string, int>();

            // add some people and their zip codes
            //
            // dictionaryName[key] = value;

            personInfo["Frank"] = 85339;
            personInfo["Evan"]  = 48009;
            personInfo["Joshua"]= 15658;
            personInfo["Ryan"]  = 48116;

            personInfo.Add("Jenna", 85339); // another way to a key to a dictionary

            personInfo["Frank"] = 44143; // specifying a key that already exists in the dictionary

            // personInfo.Add("Frank", 44143); // specifying a key that already exists in the dictionary
            // when using .Add() you get an error


            Console.WriteLine("Joshua lives in: " + personInfo["Joshua"]);

            Console.WriteLine("Whose zip code do you want? ");
            string name = Console.ReadLine();

            try
            {
                Console.WriteLine(name + " lives in: " + personInfo[name]);
            }
            catch(KeyNotFoundException exceptionInfo)
            {
                Console.WriteLine("Error, looking for: " + name);
                Console.WriteLine(exceptionInfo.Message);
            }




            Console.ReadLine();


            // if you want to walkthrough the entire dictionary with a foreach 
            // you need to get all the keys in the dictionary

            // use the KeyValuePair object in the foreach

            // KeyValuePair<key-type, value-type> name-for-entry

            foreach (KeyValuePair<string, int> anEntry in personInfo)
            {
                Console.Write(anEntry.Key + " lives in zip code " + anEntry.Value);
            }

            Console.WriteLine("Please press enter to end program..."); 
            Console.ReadLine();
        }
    }
}
