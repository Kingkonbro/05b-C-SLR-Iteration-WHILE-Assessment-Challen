using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The user is asked to enter their guesses
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            int r1 = 0;
            int r2 = 0;
            int r3 = 0;

            int count =0;

            // The loop loops until all of the numbers match up
            while ((num1 != r1) || (num2 != r2) || (num3 != r3))
            {
                count++;
                r1 = random.Next(1, 31);
                r2 = random.Next(1, 31);
                r3 = random.Next(1, 31);
                Console.WriteLine($"Draw {count}: {r1}, {r2}, {r3}");
            }
            // Final count is displayed to the user
            Console.WriteLine($"It took {count} draws to match your numbers!");
        }
    }
}
