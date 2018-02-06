using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Question4
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number:");
            double x = Double.Parse(Console.ReadLine());
            Console.WriteLine("The squared of {0} = {1}", x, x * x);
        }
    }
}
