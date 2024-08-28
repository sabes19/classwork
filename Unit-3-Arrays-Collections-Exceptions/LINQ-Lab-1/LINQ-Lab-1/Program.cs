using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq; // activates the linq namespace

namespace LINQ_Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {10, 2330, 112233, 12, 949, 3764, 2942, 523863}; // decare variable to hold array of integers


            // 1. find the minimum value
            // use the min() method provided by using System.Linq
            int minValue = numbers.Min();

            // output the results
            Console.WriteLine($"1. The minimum value of the Array is {minValue}");
            
            // 2. Find the max value
            // use the max() provided by using System.Linq
            int maxValue = numbers.Max();

            // output the results
            Console.WriteLine($"2. The maximum value of the Array is {maxValue}");

            // 3. Find the max value less than 10000
            var result = numbers.Where(x => x < 10000).Max();  // having an issue with #3 moving on for now

            //4. Find all values between 10 and 100

            // Random Joke i found looking for help on stack overflow
            // Why do Java developers wear glasses? Because they can't C#! 

            var numbersInBetween = numbers.Where(x => x >= 10 && x <= 100).ToList(); // use .ToList to convert IEnumerable to List
            Console.WriteLine("4. The values between 10 and 100 are " + string.Join(", ", numbersInBetween));

            // 5. Find all the values between 10000 and 99999 inclusive
            var numbers10k99k = numbers.Where(x => x >= 10000 && x <= 99999).ToList();
            Console.WriteLine("5. Values between 10000 and 99999 are inclusive: " + string.Join(", ", numbers10k99k));

            // 6. Count all the even numbers 
            int evenNumbers = numbers.Where(x => x % 2 == 0).Count();
            Console.WriteLine($"6. Count of even numbers: {evenNumbers}");

            // close out with the console.Read so everything prints to console.
            Console.Read();               
        }
    }
}
