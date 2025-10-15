using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The amount of money that the user wants to withdraw in a whole number
            Console.Write("Enter the amount to withdraw: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            // The correct amount of each bill is displayed
            Console.WriteLine("Dispensing cash:");
            while (amount >= 20)
            {
                amount -= 20;
                Console.WriteLine("Dispensing £20");
            }
          
            while (amount >= 10)
            {
                amount -= 10;
                Console.WriteLine("Dispensing £10");
            }

            while (amount >= 5)
            {
                amount -= 5;
                Console.WriteLine("Dispensing £5");
            }

            // If there is a remaining amount it would be displayed to the user
            if (amount > 0)
            {
                Console.WriteLine($"Remaining amount: £{amount}");
            }
        }
    }
}
