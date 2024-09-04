using System;
using System.Collections.Generic;


namespace Day_1_Student_Scores_Class_Example
{
    // We removed internal attribute which would limit where we could use this class
    class Student
    {
        // define data we want to store for a student
        public string studentName;
        public List<double> testScores;

        // methods for the class
        //
        // Constructors
        //
        // Do we need a defualt constructor? does a fefualt student make sense?\
        //      No - so no 0-arg Constructor needed
        //
        // Do we want to create student with just a name (with no test scores)?
        //      yes! therefore create a 1-arg constructor that takes a student name

        // Do we want to create a student with just test scores (with no name)?
        //      no! no 1-arg constructor that takes test scores only

        // do we want to create a student that already has test scores?
        //      yes - create a 2-argument constuctor that takes a student name and their score

        // create a 1-arg constructor that takes a Student name

        public Student(string name)
        {
            studentName = name;
            testScores = new List<double>(); // Define and assign a default list for testScores
        }

        // create a 2-arg constructor that takes a Student Name and their scores
        public Student(string name, List<double> scores)
        {
            studentName = name;
            testScores = scores;
        }

        // additional methods to support the class

        // allow user to add a score to testScores

        public void ScoreAdd(double score)
        {
            testScores.Add(score);
        }


        // display the data in an object
        public void ShowStudent()
        {
            // notice the use of ToString for the List to get it in a displayable format
            Console.WriteLine($"\nName: {studentName} Test Scores: ");
            foreach(double aScore in testScores)
            {
                Console.Write($"{aScore} , ");
            }
        }


    } // end of Student Class
} // End of Main
