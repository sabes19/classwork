/************************************************************************
GamblerDAO Starter Code
*
* DAO - Data Access Object - Used to Manipulate data in s data source
**************************************************************************/

using Microsoft.AspNetCore.Http.HttpResults;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace APITutorial.Model
{
    public class GamblerDAO
    {
        // this class handles all data related activity for the gambler data

        // Data Source - static so it lives as long as the server live
        private static List<Gambler> gamblers;   // Reference to data source

        // Constructor
        public GamblerDAO()
        {
            gamblers = new List<Gambler>(); // Instantiate the data source object

            // Initialize the data source
            gamblers.Add(new Gambler(12,    "T Judson Smith",   "Los Angeles, CA",  1398.65,    DateTime.Parse("05/01/1972")));
            gamblers.Add(new Gambler(49,    "Dana Imori",       "",                 7580.50,    DateTime.Parse("08/08/1938")));
            gamblers.Add(new Gambler(201,   "S.Q. Elle",        "Relational, DA",   1000000.01, DateTime.Parse("05/23/1995")));
            gamblers.Add(new Gambler(54,    "Neil Bransfield",  "Seattle, WA",      5000.00,    DateTime.Parse("03/11/1959")));
            gamblers.Add(new Gambler(382,   "Stickman Nelson",  "Cumberland, MD",   12983.75,   DateTime.Parse("10/21/1955")));
            gamblers.Add(new Gambler(572,   "Al Mostbroke",     "Clayton MO",       4505.55,    DateTime.Parse("01/18/1975")));
        }

        // Method to return all entries in the data source
        public List<Gambler> getGamblers()
        {
            return gamblers;
        }

        // Method to return the data of a specific gambler based on their ID
        public Gambler getSpecificGambler(int id)
        {
            // find the gambler with the ID passed to us in the data source
            // .Find will return the element that matches the condition or null
            return gamblers.Find(g => g.Id == id);       
        }

        // Method to return a Gambler by name or partial Name
        public List<Gambler> getGamblerDataByName(string theName)
        {
            return (List<Gambler>) gamblers.Where(g => g.Name.Contains(theName)).ToList();
        }

        // Method to add a Gambler to the data source
        public Gambler AddAGambler(Gambler aGambler)
        {
            gamblers.Add(aGambler);
            return aGambler;            // return the gambler we got
        }

    }
}
