using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_BasicCorePrograms
{
    internal class FlipCoin
    {
        public static void FindPercentageOffFlipCoin()
        {
            int tailCount = 0;
            int headCount = 0;
            Console.WriteLine("How many times to flip the coin ?");
            int numofTimes = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            double randomInput = random.NextDouble();
            if (randomInput < 0.5)
                tailCount++;
            else
                headCount++;

            Console.WriteLine("Head Count {0} out of {1}", headCount, numofTimes);
            Console.WriteLine("Tail Count {0} out of {1}", tailCount, numofTimes);

        }
    }
}
