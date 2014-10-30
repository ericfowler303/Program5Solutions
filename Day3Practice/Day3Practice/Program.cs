using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            LetterFinder('e', "Where is my car dude");
            WordFinder("test", "When do we test the code?");
            // keep the console open
            Console.ReadKey();
        }

        /// <summary>
        /// Checks for the given letter inside of a string
        /// </summary>
        /// <param name="letter">input letter</param>
        /// <param name="inputString">input string</param>
        static void LetterFinder(char letter, string inputString)
        {
            int letterCounter = 0;
            // check to make sure the char is actually a letter in the alphabet
            if(ContainsValidLetters(letter.ToString())) {
                // iterate through each letter
                foreach (char testLetter in inputString)
                {
                    // check to see if the character matches and if it does increment the counter
                    if (letter.ToString().ToLower() == testLetter.ToString().ToLower()) letterCounter++;
                }
                Console.WriteLine(inputString + " has " + letterCounter + " instances of letter " + letter.ToString());
            }
            else { Console.WriteLine("The letter given is not a letter"); }
            
        }

        /// <summary>
        /// Checks for the given word inside of a string
        /// </summary>
        /// <param name="word">input word</param>
        /// <param name="inputString">input string</param>
        static void WordFinder(string word, string inputString)
        {
            int wordCounter = 0;
            // Split the string into individual words and put each into the list
            List<string> wordList = inputString.Split(' ').ToList();
            // loop through the words in the list
            foreach(string testWord in wordList)
            {
                // if the words match increment the counter
                if (word.ToLower() == testWord.ToLower() && ContainsValidLetters(word.ToLower())) wordCounter++;
            }

            // Check for valid word to create the proper output statement
            if (ContainsValidLetters(word.ToLower()))
            {
                Console.WriteLine(inputString + " has " + wordCounter + " instances of " + word);
            }
            else
            {
                Console.WriteLine("Not a valid input word");

            }
        }

        /// <summary>
        /// Check for valid alphabetical letters in a string
        /// </summary>
        /// <param name="word">input word</param>
        /// <returns>true if all letters are valid</returns>
        static bool ContainsValidLetters(string word)
        {
            bool valid = false;
           foreach(char letter in word)
           {
               
               if ("abcdefghijklmnopqrstuvwxyz".Contains(letter.ToString())) { valid = true;} else { return false;}
               
           }
           return valid;
        }
    }
}
