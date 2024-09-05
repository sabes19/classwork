namespace Day_2_Playing_Card_Example
{
    // this is the class to represent a simple Playing card
    // its in the same namespace as the application (for now and for simplicity
    //
    // access - public - anyone can access and use
    //        - private - only members of this class can access and use
    // 
    //
    public class PlayingCard
//  access type  name
    {
        /********************************************************
        * Data Members (attributes, properties, variables)
        *********************************************************/

        // define instance variables for the class (unique attributes for each object)

        

        // define instance variables for the class (unique attributes for each object)
        //
        // instance variables are private to implement encapsulation

        private int cardValue;
        private string cardSuit;
        private string cardColor;

        // to provide access so others can "see" or "change" the data members
        //      we can provide "properties" to do that
        
        // a property is a public variable to allow access to private data
        //   using "getters" and "setters"
        //
        // a Getter will return the value in a data member
        // a setter will allow the changing of a data member
        
        // a property is typically named the same as the variable in PascalCase

        // Define properties for access to data members 
        public int CardValue // name is the data member in PascalCase
        {
            get {return cardValue;}  // getter - return the value in cardValue
            set {cardValue = value;} // setter - set cardValue to value used when assigning 
//                                     //          value is keyword representing the value
        }






        /********************************************************
        * Method members (functions that operate on that class data) 
        *********************************************************/

        // every class has at least on constructor
        //
        // constructors are responsible for initailizing that data in the object
        // constructors are public, same name as the class, no return type, may have parameters

        // constuctors to initialize all instance variables
        public PlayingCard(int theValue, string theSuit, string theColor)
        {
            cardColor = theColor; // initialize color to color passed
            cardValue = theValue; // initialize value to value passed
            cardSuit  = theSuit;  // initialize suit to suit passed
        }

        // a copy constructor to create a copy of PlayingCard from a PlayingCard
        // (aka a "deep copy")
        // this avoids two references to the same object wwhen creating an object from an object
        //
        // a copy constructor receives  an object of thje class as a parameter
        // and initializes using the data memebers in that object


        public PlayingCard(PlayingCard sourceCard)
        {
            cardColor = sourceCard.cardColor; // initialize color to color passed
            cardSuit  = sourceCard.cardSuit;  // initialize suit to suit passed
            cardValue = sourceCard.cardValue; // initialize value to value passed
        }

        /******************************************************************************
        * Method overrides to have classs behave the way we want, not the defualt way
        ******************************************************************************/
        
        // Override the defualt ToString() method
        // we MUST be sure the method signiture matches the method we are overriding
        // an override is substituting your processing for the defualt processing
        // good idea to autofill

        // since the default ToString() returns a string and receives no parameters
        // the override must do the same

        // the override key work, tells C# this is an override for default behavior
        //                         C# will check to be sure your override signiture
        //                                                  matches the defualt

        // a method signiture identifies the method and contains
        //
        // 1. return type
        // 2. a method name
        // 3. parameter

        // the purpose of ToString() is to present an object of the class as a string
        public override string ToString() 
        {
            return $"PlayingCard: Value={cardValue}, Color={cardColor}, Suit={cardSuit}";
        }



    } // end of PlayingCard class
} // End of namespace
