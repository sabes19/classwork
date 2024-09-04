using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;


namespace Day_1_Student_Scores_Class_Example
{
    // this is an application that uses and manipulates objects of a class
    internal class Program
    {
        static void Main(string[] args)
        {
            // define a student
            Student student1 = new Student("Dog");

            // Define a student with some test scores
            // Define a list of test scores to send to the constructor
            List<double> theScores = new List<double>();
            theScores.Add(100);
            theScores.Add(50);
            
            Student student2 = new Student("Fish", new List<double>());

            // add test scores to for student
            //
            // we need to use a method provided by the class to do so

            student1.ScoreAdd(75);
            student1.ScoreAdd(86);
            student1.ScoreAdd(69);
            student1.ScoreAdd(88);     

            
            // Display the data associated with each student using a method provided by the class
            //         because the Class owns the data and knows how to display it
            //         so we dont have to do any work as the user of the class to display 

            Console.WriteLine("Student1 is: " + student1); // DOES not display contents of the object
                                                           // it displays: namespace.classname

            student1.ShowStudent(); // use  the object of the class to run a method of the class
            student2.ShowStudent(); // use  the object of the class to run a method of the class


            Console.WriteLine("\n\nPress Enter to end");
            Console.ReadLine();




        }
    }
}
