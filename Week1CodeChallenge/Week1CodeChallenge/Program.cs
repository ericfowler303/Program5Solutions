using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // FizzBuzz part 1
            for (int i = 0; i < 21; i++)
            {
                FizzBuzz(i);
            }
            // FizzBuzz part 2
            for (int i = 92; i > 78; i--)
            {
                FizzBuzz(i);
            }

            // Yodaizer 
            Yodaizer("You spin me right round");
            //Yodaizer Bonus
            Yodaizer("I like code");

            // TextStats - with bonus
            TextStats("quit playing with my feelings!");

            // IsPrime function
            for (int i = 1; i < 26; i+=2)
            {
                if (IsPrime(i))
                { // is prime
                    Console.WriteLine(i + " is a prime number");
                }
                else 
                { // is not prime
                    Console.WriteLine(i);
                }
            }

            // DashInsert
            DashInsert(8675309);

            // Keep the console open
            Console.ReadKey();
        }

        /// <summary>
        /// Find the FizzBuzz
        /// divisible by 5 = "Fizz"
        /// divisible by 3 = "Buzz"
        /// divisible by both = "FizzBuzz"
        /// if none print the number
        /// </summary>
        /// <param name="number">number to check</param>
        static void FizzBuzz(int number)
        {
            if (number % 5 == 0 && number % 3 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number);
            }
        }

        /// <summary>
        /// Takes input text and reverses the order of the words
        /// </summary>
        /// <param name="text">input text</param>
        static void Yodaizer(string text)
        {
            // Split the string into individual words
            List<string> words = text.Split().ToList();
            
            // Bonus Yoda check
            if (words.Count == 3)
            {
                // format into Yoda speak
                Console.WriteLine("{0}, {1} {2}", words[2], words[0], words[1]);
            }
            else
            {
                // reverse the words and print them out
                words.Reverse();
                foreach (string oneWord in words)
                {
                    Console.Write(oneWord + " ");
                }
                Console.Write("\n");
            }
        }
        /// <summary>
        /// Prints out a set of stats about the given input string
        /// </summary>
        /// <param name="input">string to analyze</param>
        static void TextStats(string input)
        {
            // Print the string that will be analyzed
            Console.WriteLine("String to be analyzed:");
            Console.WriteLine(input);

            // Find number of characters
            Console.WriteLine("Number of characters: " + input.Length);
            // Find number of words
            List<string> wordList = input.Split().ToList();
            Console.WriteLine("Number of words: " + wordList.Count);
            
            // Find the rest of the info
            int vowelCounter = 0;
            int consonantCounter = 0;
            int specialCounter = 0;
            foreach (char letter in input)
            {
                // Find number of vowels
                if ("aeiou".Contains(letter.ToString())) { vowelCounter++; }
                //Find number of consonants
                if (!("aeiou".Contains(letter.ToString()))) { consonantCounter++; }
                // Find number of special characters
                if (" !?.".Contains(letter.ToString())) { specialCounter++; }
            }
            Console.WriteLine("Number of vowels: " + vowelCounter);
            Console.WriteLine("Number of consonants: " + consonantCounter);
            Console.WriteLine("Number of special characters: " + specialCounter);

            // Sort using ascending comparison
            wordList.Sort(new StringLengthAscComparer());

            // Bonus

            // Longest Word
            Console.WriteLine("Longest word: " + wordList[0]);
            // 2nd Longest Word
            Console.WriteLine("2nd Longest word: " + wordList[1]);
            // Shortest Word
            Console.WriteLine("Shortest word: " + wordList[wordList.Count - 1]);
        }

        /// <summary>
        /// Implement IComparable to compare string lengths in ascending order
        /// </summary>
        class StringLengthAscComparer : IComparer<string>
        {
            public int Compare(string string1, string string2)
            {
                if (string1.Length < string2.Length)
                {
                    // String 2 is longer
                    return 1;
                }
                if(string1.Length > string2.Length)
                {
                    // String 1 is longer
                    return -1;
                }


                // same length
                return 0;
            }
        }
        /// <summary>
        /// Check is a number is prime or not
        /// </summary>
        /// <param name="number">number to check</param>
        /// <returns>true if prime</returns>
        static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                // Check if the number has a factor
                if (number % i == 0) { return false;}
            }
            // Since there were no factors of number found, it must be prime
            return true;
        }
        /// <summary>
        /// Insert a dash(-) inbetween any two odd numbers that are in sequence
        /// </summary>
        /// <param name="number">number that needs dashes</param>
        static void DashInsert(int number)
        {
            string numberString = number.ToString();
            string outputString ="";
            bool previousWasOdd = false;
            foreach (char letter in numberString)
            {
                // Check if the number is odd
                if(int.Parse(letter.ToString()) % 2 !=0 )
                {
                    // Because the current number is odd and the previous was, insert the dash
                    if (previousWasOdd)
                        outputString += "-";
                    // output the current odd nummber
                    outputString += letter.ToString();
                    // set the boolean for the next time around
                    previousWasOdd = true;
                }
                else
                {
                    // output the current even number
                    outputString += letter.ToString();
                    // Since it's even, reset the boolean
                    previousWasOdd = false;
                }
            }
            // Write the entire new string to the console
            Console.WriteLine(outputString);
        }
    }
}
