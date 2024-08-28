using System;

namespace Practice
{
    internal class Program
    {
        static void Main()
        {
            // declare the variables
            int number1 = 10;
            int number2 = 20;
            int number3 = 10;

            // test IsTheSame method
            bool truefalse1 = IsTheSame(number1, number2); // true
            bool truefalse2 = IsTheSame(number1, number3); // fasle

            Console.WriteLine(result1); // output: true
            Console.WriteLine(truefalse2); // output: false
            Console.Read();
        } // end of main

        static bool IsTheSame(int number1, int number2)
        { 
            return number1 == number2;
        }
    }
}
