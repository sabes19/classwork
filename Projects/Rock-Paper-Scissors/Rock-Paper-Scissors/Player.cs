using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors



{
    public abstract class Player // class 
    {

        // Instance variables in a class should be private to implement encapsulation

        private string name;         // player name
        private Roshambo.RoshamboValues choice;     // Roshambo enum object

        // define properties to control access to the instance variables, to maintain encapsulation
        // Property, by convention is the instance variable name in PascalCase
        public string Name { get { return name; } } // No setter defined, read-only property

        public Roshambo.RoshamboValues Choice
        {
            get { return choice; }
            set { choice = value; }
        }





        // create constructor
        // initialize objects 
        // no return type, same name as class, may take parameters

        public Player(string name, Roshambo.RoshamboValues choice)
        {
            this.name   = name;
            this.choice = choice;
            // this. indicates the current object if the parameters have the same name
        }

        public abstract Roshambo GenerateRoshambo(); // public to allow inheritance




        }







    }
}
