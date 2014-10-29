using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDay2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Declaring Variables
            string myName = "Eric Fowler";
            int myAge = 26;
            bool myBool = true;
            List<string> productsList = new List<string>() { "basketball", "baseball glove", "tennis shoes", "hockey puck" };

            // Printing variables to the console using Console.WriteLine()
            Console.WriteLine("My name is " + myName + " and I'm a beast of a programmer");
            Console.WriteLine("I am " + myAge + " years awesome");
            Console.WriteLine("I set my boolean value equal to " + myBool);

            for (int i = 0; i < productsList.Count(); i++)
            {
                Console.WriteLine(productsList[i]);
            }

            // For Loop Practice
            // #9
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }
            // #10
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            // #11
            for (int i = 10; i < 31; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            // #12
            for (int i = 100; i > 74; i--)
            {
                if (i % 5 == 0) { Console.WriteLine(i);}
            }

            // While Loop Practice
            // #13
            int counter13 = 1;
            while (counter13 < 11)
            {
                Console.WriteLine(counter13);
                counter13++;
            }
            // #14
            int counter14 = 10;
            while (counter14 > 0)
            {
                Console.WriteLine(counter14);
                counter14--;
            }
            // #15
            int counter15 = 15;
            while (counter15 < 31)
            {
                if (counter15 % 2 == 0) { Console.WriteLine(counter15); }
                counter15++;
            }
            // #16
            int counter16 = 100;
            while(counter16 >74) {
                if (counter16 % 5 == 0) { Console.WriteLine(counter16); }
                counter16--;
            }
            // #17
            int counter17 = 1;
            while (myBool)
            {
                if(counter17 % 4 ==0)
                {
                    myBool = false;
                }
                else
                {
                    Console.WriteLine(counter17);
                    counter17++;
                }
            }

            // Putting it together
            // #18
            Console.WriteLine("My name, " + myName + ", has " + myName.Length + " in it.");

            // #19
            Console.WriteLine("My product list has " + productsList.Count() + " in it.");

            // #20
            for (int i = 0; i < productsList.Count(); i++)
            {
                Console.WriteLine(productsList[i] + " has " + productsList[i].Length + " in it");
            }


            // #22
            Greeting("Beef Hardchest");
            // #23
            Greeting(myName);

            // #25
            DoubleIt(1337);
            //#26
            DoubleIt(myAge);

            // #28
            Multiply(2, 8);
            // #29
            Multiply(3, myAge);

            // #31
            LoopThis(20, 30);
            // #32
            LoopThis(0, myAge);

            // #34
            SuperLoop(0, 100, 15);
            // #35
            SuperLoop(0, 200, myAge);

            // #37
            Console.WriteLine(NewGreeting("Neil deGrasse-Tyson"));
            // #38
            Console.WriteLine(NewGreeting(myName));

            // #40
            Console.WriteLine("10 tripled is "+TripleIt(10));
            // #41
            Console.WriteLine(myAge + " tripled is " + TripleIt(myAge));

            // #43
            Console.WriteLine(RealMultiply(5, 10));
            // #44
            Console.WriteLine(RealMultiply(2, myAge));

            // Function Call Madness
            // #45
            SuperLoop(RealMultiply(1, 5), TripleIt(myAge), TripleIt(myAge - 10));
            // #46
            SuperLoop(RealMultiply(1, TripleIt(3)), TripleIt(RealMultiply(myAge, 7)), TripleIt(myAge - RealMultiply(2, 4)));

            //keep the console open
            Console.ReadKey();
        }

        // Declaring and calling functions
        // #21 
        static void Greeting(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        // #24
        static void DoubleIt(int number)
        {
            Console.WriteLine(number + " doubled is " + (number * 2));
        }

        // #27
        static void Multiply(int num1, int num2)
        {
            Console.WriteLine(num1 + " times " + num2 + " is " + (num1 * num2));
        }

        // #30
        static void LoopThis(int startNum, int endNum)
        {
            Console.WriteLine("I'm looping from " + startNum + " to " + endNum);
            for (int i = startNum; i <= endNum; i++)
            {
                Console.WriteLine(i);
            }
        }
        
        // #33
        static void SuperLoop(int startNum, int endNum, int increment)
        {
            int loopCount = 0;
            Console.WriteLine("I'm looping from " + startNum + " to " + endNum + ", incrementing " + increment + " each time");
            for (int i = startNum; i <= endNum; i+=increment)
            {
                Console.WriteLine(i);
                loopCount++;
            }
            Console.WriteLine("That loop was craaaaaazy, we looped " + loopCount + " times");
        }

        // Declaring and Calling Return Functions
        // #36
        static string NewGreeting(string name)
        {
            return "Hello, " + name;
        }

        // #39
        static int TripleIt(int number)
        {
            return number * 3;
        }
        
        // #42
        static int RealMultiply(int num1, int num2)
        {
            return num1 * num2;
        }

    }
}
