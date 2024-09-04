using System;

namespace StarTrekStuff
{
    public class StarFleetPersonnel
    {
        // data associated with the class
        //
        // access modifier idicates who has access to the items
        //
        //      public - anyone with an object 



    //  access data
  //  modifier type   variable-name

        public string name;
        public string rank;
        public string assignment;

        //methods assocaited with the class
        // typically a class has one or more constructors
        //
        // since a class is a programmer defined data type,
        // the programmer must define how it is to be initializes
        //
        // !!! a constructor is a method that initialize an object when it is instantiated/create
        //
        // !!! a constructor has no return type and has the same name as the class
        // !!!               may receive parameters to initialize a new object
        // 
        // the constructor's job is to assign values to the data for the class
        // 
        //
        //
        // !!! 3-argument constructor - it receives 3 values used to initialize a new object
        // 

        public StarFleetPersonnel(string personName, string theirRank, string theirAssignment)
        {
            name       = personName;
            rank       = theirRank;
            assignment = theirAssignment;
        }
        
        

        /************************************************************************************
         * Display a line from the list parsed into individual values
         ************************************************************************************/
        public void DisplayCrewMember()
        {
            Console.WriteLine($"\nName:\t{name}\nCrew:\t{assignment}\nRank:\t{rank}");
        } // End of DisplayLine()


    } // End of class StarFleetPersonnel
}  // End of namespace StarTrekStuff