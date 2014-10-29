using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call FizzBuzz for each test number
            for (int i = 1; i < 30; i++)
            {
                FizzBuzz(i);
            }

            // keep the console open
            Console.ReadKey();
        }

        static void FizzBuzz(int number)
        {
            // if the number is divisable by 5 and 3 print "FizzBuzz"
            if (number % 5 == 0 && number % 3 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 5 == 0)
            {
                // is divisable by 5
                Console.WriteLine("Fizz");
            }
            else if (number % 3 == 0)
            {
                // is divisible by 3
                Console.WriteLine("Buzz");
            }
            else
            {
                // The number is not divisible by 3 or 5 or both together, print the number
                Console.WriteLine(number);
            }
        }
    }
}
