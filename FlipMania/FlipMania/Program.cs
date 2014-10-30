using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipMania
{
    class Program
    {
        static void Main(string[] args)
        {
            FlipCoins(10000);
            FlipForHeads(10000);

            // keep the console open
            Console.ReadKey();
        }

        /// <summary>
        /// Flip a coin a number of times and write the result to the console
        /// </summary>
        /// <param name="numberOfFlips">how many coin flips</param>
        static void FlipCoins(int numberOfFlips)
        {
            // Check for valid input
            if (IsValidInt(numberOfFlips))
            {
                int numberOfHeads = 0;
                int numberOfTails = 0;
                Random rng = new Random();

                // Flip a number of times
                for (int i = 0; i < numberOfFlips; i++)
                {
                    // Check if heads or tails and increment the respective counter
                    if (rng.Next(2) == 0) { numberOfHeads++; } else { numberOfTails++; }
                }

                // Write out the results to the console
                Console.WriteLine("We flipped a coin " + numberOfFlips + " times.");
                Console.WriteLine("Number of Heads: " + numberOfHeads);
                Console.WriteLine("Number of Tails: " + numberOfTails);
            }
        }

        static void FlipForHeads(int numberOfHeads)
        {
            // Check for valid input
            if (IsValidInt(numberOfHeads))
            {
                int numberOfHeadsFlipped = 0;
                int totalFlips = 0;
                Random rng = new Random();

                // Flip until there are enough heads found
                while (numberOfHeadsFlipped <= numberOfHeads)
                {
                    // increment if it is a head that is found
                    if (rng.Next(2) == 0) { numberOfHeadsFlipped++; }
                    // totalFlips gets incremented regardless of the result
                    totalFlips++;
                }

                // Write the results to the console
                Console.WriteLine("We are flipping a coin until we find " + numberOfHeads + " heads");
                Console.WriteLine("It took " + totalFlips + " to find " + numberOfHeads + " heads");
            }
        }

        /// <summary>
        /// Check to see if the integer is a positive number that's not zero
        /// </summary>
        /// <param name="someInt">integer to check</param>
        /// <returns>true if valid positive number</returns>
        static bool IsValidInt(int someInt)
        {
            if (someInt > 0) { return true; } else { return false; }
        }
    }
}
