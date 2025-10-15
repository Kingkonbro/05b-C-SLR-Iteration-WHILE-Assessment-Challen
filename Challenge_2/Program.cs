using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int discountInc = 0;

            int discountStart = 10;
            int discountMax = 60;

            int discountTotal = discountStart;

            // A new random number is generated
            discountInc = random.Next(5, 11);
            do
            {
                // The Total so far is displayed to the user
                Console.WriteLine($"Discount: {discountTotal}%");

                // Another random number is picked and added to the variable 'discountTotal'
                discountInc = random.Next(5, 11);
                discountTotal += discountInc;

                // The while loop repeats if the discount is below the max
            } while ( discountTotal < discountMax );

            /* The ensure that the max discount is displayed only once its checked if the
            /* discount is the max and if not then 60 is displayed
            */
            if ( discountTotal >= discountMax )
            {
                Console.WriteLine($"Discount: {discountMax}%");
            }
        }
    }
}
