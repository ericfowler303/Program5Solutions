using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickGroups
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Simple Method
            Console.WriteLine("The simple but unbalanced way from class");
            SimpleGrouping(4, 18);
            // The Balanced Method
            Console.WriteLine("\nProperly balanced method");
            PickGroups(4, 18);

            // Keep the console open
            Console.ReadKey();
        }

        /// <summary>
        /// A simple method to determine groups based off of the desired group size
        /// </summary>
        /// <param name="sizeOfGroup">maximum size of group</param>
        /// <param name="sizeOfClass">total people in class</param>
        static void SimpleGrouping(int sizeOfGroup, int sizeOfClass)
        {
            // Can't have zero or negative values for either input
            if (sizeOfGroup > 0 && sizeOfClass > 0)
            {
                List<int> people = new List<int>(sizeOfClass);
                List<int> currentGroup = new List<int>();
                Random rng = new Random();
                int groupCounter = 1;

                // populate the list with sequencial number
                for (int i = 1; i <= sizeOfClass; i++)
                {
                    people.Add(i);
                }

                // while there are people to be assinged
                while (people.Count() != 0)
                {
                    // while the current group hasn't met the size requirement
                    while (currentGroup.Count < sizeOfGroup)
                    {
                        // get a random person
                        int ranIndex = rng.Next(people.Count);
                        if (people.Count == 0) { break; }
                        currentGroup.Add(people[ranIndex]);
                        // remove person after moved to group
                        people.RemoveAt(ranIndex);
                    }

                    Console.WriteLine("Group #" + groupCounter);
                    foreach (int number in currentGroup)
                    {
                        Console.Write("#" + number);
                        // For evenly spaced columns for numbers under 100
                        if (number < 10) { Console.Write(" "); }
                        Console.Write("   ");
                    }
                    Console.WriteLine();
                    groupCounter++;
                    currentGroup.Clear();
                }
            }
            else { Console.WriteLine("invalid input"); }
        }

        /// <summary>
        /// Group Picker using properly balanced arrays to determine groups based on the desired number of groups
        /// </summary>
        /// <param name="numGroups">desired number of groups</param>
        /// <param name="sizeOfClass">total people in the class</param>
        static void PickGroups(int numGroups, int sizeOfClass)
        {
            // Can't have zero or negative inputs
            if (numGroups > 0 && sizeOfClass > 0)
            {

                List<int> people = new List<int>(sizeOfClass);
                Random rng = new Random();
                int[,] groups;
                int maxNumOfPeoplePerGroup = 0;
                int remainder = sizeOfClass % numGroups;

                // Check for evenly based groups or not
                if (remainder != 0)
                {
                    // need to subtract the remainder from sizeOfClass to findd how many groups
                    maxNumOfPeoplePerGroup = (sizeOfClass - remainder) / numGroups;
                    // initalize multidimensional array to hold the people
                    groups = new int[numGroups, maxNumOfPeoplePerGroup + 1];
                }
                else
                { // divides evenly
                    maxNumOfPeoplePerGroup = sizeOfClass / numGroups;
                    // initalize multidimensional array to hold the people
                    groups = new int[numGroups, maxNumOfPeoplePerGroup];
                }

                // Calculate the number of empty slots there will be to later balance the array makeup
                int emptySlots = sizeOfClass - (maxNumOfPeoplePerGroup * numGroups);

                // populate the list with sequential number
                for (int i = 1; i <= sizeOfClass; i++)
                {
                    people.Add(i);
                }

                /*
                 *Fill up the array with people 
                 */

                // Group index
                for (int x = 0; x < groups.GetLength(0); x++)
                {
                    // People index
                    for (int y = 0; y < groups.GetLength(1); y++)
                    {
                        if (remainder == 0)
                        {
                            // For the even groups

                            // get a random person
                            int ranIndex = rng.Next(people.Count);
                            if (people.Count == 0) { break; }
                            addPersonToGroup(groups, people, x, y, ranIndex);
                        }
                        else
                        {
                            // Check to achieve group balance based on optimal group sizing
                            if ((numGroups - emptySlots) <= x && y == (groups.GetLength(1) - 1)) { break; }

                            // get a random person
                            int ranIndex = rng.Next(people.Count);
                            if (people.Count == 0) { break; }
                            addPersonToGroup(groups, people, x, y, ranIndex);
                        }
                    }

                }

                // Print out the results
                for (int i = 0; i < groups.GetLength(0); i++)
                {
                    // pass the array and current group to be printed out
                    printGroup(groups, i);
                }
            }
            else { Console.WriteLine("invalid input"); }
        }
        /// <summary>
        /// Commonly called code to add a person to a group
        /// </summary>
        /// <param name="groups">array of the groups</param>
        /// <param name="people">list of the people</param>
        /// <param name="x">x value of group array</param>
        /// <param name="y">y value of group array</param>
        /// <param name="ranIndex">current random number index</param>
        private static void addPersonToGroup(int[,] groups, List<int> people, int x, int y, int ranIndex)
        {
            // add person to group array
            groups[x, y] = people[ranIndex];
            // remove person after moved to group
            people.RemoveAt(ranIndex);
        }
        /// <summary>
        /// Print out a group to the console
        /// </summary>
        /// <param name="peopleInGroup">array of people in groups</param>
        /// <param name="groupNumber">which group to print this time</param>
        private static void printGroup (int[,] peopleInGroup, int groupNumber)
        {
            Console.WriteLine("Group #" + (groupNumber+1));

            for (int i = 0; i < peopleInGroup.GetLength(1); i++)
            {
                if (peopleInGroup[groupNumber, i] != 0)
                {
                    Console.Write("#" + peopleInGroup[groupNumber, i]);
                    // For evenly spaced columns for numbers under 100
                    if (peopleInGroup[groupNumber, i] < 10) { Console.Write(" "); }
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
    }
}
