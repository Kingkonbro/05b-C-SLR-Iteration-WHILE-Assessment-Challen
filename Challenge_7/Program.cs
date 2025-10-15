using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double prey = 30;
            double predators = 5;
            double a = 0.8;
            double b = 0.5;
            double c = 0.1;
            double d = 0.3;
            double e = 2.718;

            double preyGrowthRate = 0;
            double predatorsGrowthRate = 0;

            int generation = 0;

            while (((predators > 2) && (prey > 2)) && generation < 10 )
            {
                generation++;
                Console.Write($"Generation: {generation}\t | ");

                preyGrowthRate = Math.Pow(e,a-(c*predators));
                prey *= preyGrowthRate;
                prey = Math.Round(prey);
                Console.Write($"Prey: {prey}\t |");

                predatorsGrowthRate = Math.Pow(e, (d*c*prey)-b);
                predators *= predatorsGrowthRate;
                predators = Math.Round(predators);
                Console.Write($"Predators: {predators}");

                Console.WriteLine();
            }
            

        }
    }
}
