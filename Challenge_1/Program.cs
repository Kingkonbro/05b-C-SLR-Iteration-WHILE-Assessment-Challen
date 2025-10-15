using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string binary = "";
            double denary0 = 0;
            // The user is asked to enter a denary whole number
            Console.Write("Enter a denary number: ");
            double denary = Convert.ToSingle(Console.ReadLine());
            
            while (denary > 0)
            {
                // The variable 'denary0' is assigned the value of the variable 'denary'
                denary0 = denary;

                // The variable 'denary' is divided by 2 and truncated
                Console.Write($"\t{denary}");
                denary /= 2;
                denary = (Math.Truncate(denary));

                // The remainder is calculated when 'denary0 is divided by 2
                Console.Write($"\t{denary}");
                denary0 %= 2;
                Console.Write($"\t{denary0}");

                // The list od binary so far is displayed
                Convert.ToString(denary0);
                binary = $"{denary0}{binary}";

                Console.Write($"\t{binary}");
                Console.WriteLine();
            }

            // The binary is displayed to the user
            Console.WriteLine($"Binary representation: {binary}");
             
            
        } 
    }
}
