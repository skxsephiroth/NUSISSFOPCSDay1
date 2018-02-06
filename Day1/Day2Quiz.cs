using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Day2Quiz
    {
        static void Main()
        {
            Console.WriteLine("Please enter the length in cm:"); // Ask user to enter input
            double LengthInCm = Double.Parse(Console.ReadLine()); // Read input enter by user // Convert to number
            double LengthInInch = LengthInCm / 2.54; // Convert to inch formula
            Console.WriteLine("{0:0.000}", LengthInInch); // Print out the result

        }
    }
}
