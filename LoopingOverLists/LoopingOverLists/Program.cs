using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingOverLists
{
    class Program
    {
        static void Main(string[] args)
        {
            LoopOverAList();
            LoopOverWordsInAString("the red fox jumps over the log");

            Console.ReadKey();
        }
        /// <summary>
        /// Initalize and loop over a list and print out the words containing 'ball'
        /// </summary>
        static void LoopOverAList()
        {
            // create a list of sports
            List<string> sportsList = new List<string>() {"baseball","tennis", "diving", "swimming"};
            // add football to the list
            sportsList.Add("football");
    
            // loop over the sports list and display all elements that contain the string 'ball'
            foreach (string item in sportsList)
            {
                // if it contains 'ball' print to the console
                if (item.ToLower().Contains("ball")) { Console.WriteLine(item); }
            }
        }

        /// <summary>
        /// Print out each word of a string, one per line
        /// </summary>
        /// <param name="inputString"></param>
        static void LoopOverWordsInAString(string inputString)
        {
            // split the string into individual words and store in the list
            List<string> wordList = inputString.Split(' ').ToList();
            foreach (string item in wordList)
            {
                // print out each item in the list
                Console.WriteLine(item);
            }
        }
    }
}
