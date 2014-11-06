using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2LambdaPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            FunTime();

            Console.ReadKey();
        }
        static void FunTime()
        {
            List<string> funtimeList = new List<string>() { "blueberry", "boisonberry", "raspberry", "apple", "pear", "orange"};
            // print out in order
            Console.WriteLine("In Order: "+string.Join(", ", funtimeList.OrderBy(x => x)));
            // print only the ones with berry
            Console.WriteLine("Contains \"berry\": " +string.Join(", ",funtimeList.Where(x => x.Contains("berry"))));

            // print on the non berry items, ordered by length of the word
            Console.WriteLine("non berry, by length: " + string.Join(", ", funtimeList.Where(x => !x.Contains("berry")).OrderBy(x =>x.Length)));

            // print only the items that have 5 or more characters
            Console.WriteLine("more then 5 characters: "+string.Join(", ", funtimeList.Where(x=>x.Length>5)));

            // Find average number of characters in the list
            Console.WriteLine("average number of characters: " + funtimeList.Average(x => x.Length));

            // Find the number of vowels in each item in the list
            Console.WriteLine("number of vowels in each word: " + string.Join(", ", funtimeList.Select(x=> x.Count(y=> "aeiou".Contains(y)))));
        }
    }
}
