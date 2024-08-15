using System;

namespace Day_5_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // An array is a series of values of the same type stored together
            // all elements are the same data type
            // once an array is created its size cant be changed
            // elements are IDd by an index (relative location)
            // indexes start at 0 (first element is at index 0)
            // highest valid index is the length of the array - 1

            // To define an array:
            //
            //      datatype[] name = new datatype [#-of-elements]  // elements are initialized to a default value
            //                                                     // numeric initalized to 0; strings empty bool fal 
            //      datatype[] name = {value1, value2, value3...] // size is determined by the number of values

            int[] charles = new int[5]; // define an array of 5

            int[] bradbury = { 2, 6, 78, 0, -3 }; // define a 5 int element array

            // set the values in the array using their index

            charles[0] = 10;
            charles[1] = 11;
            charles[2] = 12;
            charles[3] = 13;
            charles[4] = 14;

            // typlically a for-loop is used to process an array
            //
            //      for(int i=0; i < arrayName.Length; i++) // common for-Loop to process an array
            //
            // used the for-loop variable (i) as the index to the array inside the loop

            // display all elements in the array charles
            for (int i = 0; i < charles.Length; i++)
            {
                Console.WriteLine("["+i+"] " + charles[i]+ ", ");
            }
       
        }
    }
}
