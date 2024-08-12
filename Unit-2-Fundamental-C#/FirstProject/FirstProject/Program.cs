// Program.cs is the main executable file for your application

// 'using' allows you access to C# code you need for application
using System;  // gives me access to the basic C# system code (basic functionality)


// code in C# is grouped in namespaces
//
// a namespace IDs a context in which a work or thing is defined or known
//             Allows the same name or thing to be used in different contexts
//             Ex. in this class, Kendell is the name of 2 people. when its used in the 1st name, its one, but whne ist the last name its the other
namespace FirstProject
{

    // a class is used to group things that are related or used together in an application
    // every application has at least one class containing the primary (or startup code) for the app
    
    //an internal class cannot be used outside the context in which it is defined
    internal class Program // program is the name of the class that contains the application
    {
        // every application contains exactly one method called main
        // a method is a self contained unit of code
        // main is the starting point for execution of the application
        //
        // static - idicates there is only one of these
        // void - indicates that a method does not return a value
        // main - the name of the method
        // (string[] args) - indicates the data type and name of any parameters for the method
        //
        // {} are used to indicate the a self contained block of code   
        static void Main(string[] args)
        { // marks the start of code in main
        }
    }
}
