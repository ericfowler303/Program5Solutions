using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();

            int myAgeDoubled = DoubleNumber(26);
            Console.WriteLine(DoubleNumber(myAgeDoubled));

            LoopTests();
            CountVowels("aloha");
            CountVowelsTest();

            // Keep the console open
            Console.ReadKey();
        }

        /// <summary>
        /// Writes 'Hello World' to the console.
        /// </summary>
        static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        /// <summary>
        /// Doubles the integer argument
        /// </summary>
        /// <param name="num">The integer to be doubled</param>
        /// <returns>double the integer argument</returns>
        static int DoubleNumber(int num)
        {
            return num * 2;
        }
        /// <summary>
        /// Count up through a set of numbers and print them to the console
        /// </summary>
        /// <param name="startNumber">starting number</param>
        /// <param name="endNumber">inclusive ending number</param>
        static void LoopSomeNumbers(int startNumber, int endNumber)
        {
            for (int i = startNumber; i <= endNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
        /// <summary>
        /// Runs a series of tests on our LoopSomeNumbers function
        /// </summary>
        static void LoopTests()
        {
            LoopSomeNumbers(5, 10);
            LoopSomeNumbers(863428, 863430);
            LoopSomeNumbers(31, DoubleNumber(DoubleNumber(31)));
        }

        /// <summary>
        /// Count all of the vowels in a string
        /// </summary>
        /// <param name="myString">string to check for vowels</param>
        /// <returns>number of vowels</returns>
        static int CountVowels(string myString)
        {
            int vowelCount = 0;
            foreach(char i in myString.ToLower())
            {
                // check if the letter is a vowel
                if(i == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u')
                { // Since it is, add it to the vowelCount
                    vowelCount++;
                }
            }
            Console.WriteLine(myString+ " has " + vowelCount + " vowels in it.");
            return vowelCount;
        }

        static void CountVowelsTest()
        {
            // count the number of vowels counted
            int totalNumberOfVowelsCounted = 0;
            totalNumberOfVowelsCounted += CountVowels("Jackie seems like a guy that likes nickleback");
            totalNumberOfVowelsCounted += CountVowels("I love to eat mac and cheese");
            Console.WriteLine("Total Vowels Counted " + totalNumberOfVowelsCounted);
        }
    }
}
