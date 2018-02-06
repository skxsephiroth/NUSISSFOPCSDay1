using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Question5
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number:");
            double x = Double.Parse(Console.ReadLine());
            Console.WriteLine("{0} = {0:0.00} in 2 decimal places", x);
        }
    }
}
