using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Three inputs are taken, year, value and minimum resale value
            Console.Write("Enter the current year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the car's current value: £");
            double carVal = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the minimum resale value: £");
            int minResale = Convert.ToInt32(Console.ReadLine());

            // The value of the car is displayed for different years
            while (carVal > minResale)
            {
                if (year >= (year - 2))
                {
                    year++;
                    carVal *= 0.70;
                    Console.WriteLine($"Year: {year}, Car value: £{carVal}");
                }

                else
                {
                    year++;
                    carVal *= 0.80;
                    Console.WriteLine($"Year: {year}, Car value: £{carVal}");
                }

            }
            // The final verdict is displayed 
            Console.WriteLine($"The car's value fell below the resale value in year {year}");
            Console.WriteLine($"Part exchange in {year - 1}");
        }
    }
}
