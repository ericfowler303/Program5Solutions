using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace TextPrinter
{
    class Program
    {
        public static int textIndexCounter=0;
        public static string textString = "";
        public static Timer myTimer;
        static void Main(string[] args)
        {
            TextPrinter("print me out really slow", 200);
        }

        /// <summary>
        /// Print out a line of text a certain speed
        /// </summary>
        /// <param name="text">string of text to print</param>
        /// <param name="mSecDelay">delay in miliseconds between each character is printed</param>
        static void TextPrinter(string text, double mSecDelay)
        {
            // Assign the text to a public available string
            textString = text;
            // Set the text counter for the TickEvent
            textIndexCounter = text.Length;
            // Create a Timer to send off Tick events
            myTimer = new Timer(mSecDelay);
            myTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            myTimer.AutoReset = false;

            // Start the timer
            myTimer.Enabled = true;

            Console.ReadKey();
            
        }
        /// <summary>
        /// A function that handles what needs to be done during each Tick from the Timer
        /// </summary>
        private static void OnTimedEvent(object obj, ElapsedEventArgs e)
        {
            if (textIndexCounter < textString.Length)
            {
                Console.Write(textString[textIndexCounter]);
                textIndexCounter++;
            }
            else
            {
                // At the end of the string stop the timer
                myTimer.Stop();
            }
        }
    }
}
