using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The user enters the number to find the square root of
            Console.Write($"Enter a number to find the square root:");
            double value = Convert.ToDouble( Console.ReadLine() );

            double root = value;
            double lastRoot = 0;
            while (root != lastRoot)
            {
                // Newton-Raphson formula
                lastRoot = root;
                root = 0.5 * (root + (value / root));

                // Makes sure that the last value isn't displayed twice 
                if (root != lastRoot)
                {
                    Console.WriteLine($"Current estimate: {root}");
                }

            }
            // Final result displayed to the user
            Console.WriteLine($"Final approximate square root: {root}");
        }
    }
}