using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter6_WinFormsApp
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Application.SetHighDpiMode(HighDpiMode.SystemAware);
            // Application.EnableVisualStyles();
            // Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1());
            TestWindow();
            StateControlledLoop68();
            StateControlledLoop69();
        }

        public static void TestWindow() // Chapter 6, example 6-5, pg 274-275
        {
            int counter = 0; // Counter is initialized to 0. 
            string result = "";
            while (counter < 10) // The loop ends when counter is 10,
            {              // The counter begins at 1. 
                counter++; // Counter can be 10, here, but the code will still run one last time, before the condition is checked. 
                result += "\t"
                       + counter
                       + "\t"
                       + Math.Pow(counter, 2)
                       + "\n";
            }
            MessageBox.Show(result, "1 through 10 and their squares.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            /*
             * Other MessageBoxButtons  | Other MessageBoxIcons
             * .AbortRetryIgnore        | .Asterisk    (lowercase i in circle)
             * .OK                      | .Information (lowercase i in circle)
             * .OKCancel                | 
             * .RetryCancel             | .Error (white X in circle with black background)
             * .YesNo                   | .Hand  (white X in circle with black background)
             * .YesNoCancel             | .Stop  (white X in circle with black background)
             *                          |
             *                          | .Exclamation (exclamation point in a yellow triangle) 
             *                          | .Warning     (exclamation point in a yellow triangle)
             *                          |
             *                          | .None (no symbol)                         
             *                          | 
             *                          | .Question (question mark in a circle)                          
             */
        }

        public static void StateControlledLoop68() // Example 6-8, pg 282
        {
            bool moreData = true;
            while (moreData)
            {
                if(MessageBox.Show("Do you want another number?", 
                                   "State Controlled Loop", 
                                   MessageBoxButtons.YesNo, 
                                   MessageBoxIcon.Question) == DialogResult.No) 
                {
                    /*
                     * This state controlled loop will end when the user selects No. 
                     */
                    moreData = false;
                }
            }
        }
        public static void StateControlledLoop69() // Example 6-9, pg 282-283
        {
            bool moreData = true;
            Random numb = new Random();
            int s = numb.Next(100); // Returns a positibe number that is less than 100

            while (moreData)
            {
                Console.WriteLine("{0} ", s); // This doesn't seem to work anymore. 
                if (MessageBox.Show("Do you want another number?\n" +
                                    "Number is: " + s,
                                   "State Controlled Loop",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question) == DialogResult.No)
                {
                    /*
                     * This state controlled loop will end when the user selects No. 
                     */
                    moreData = false;
                }
                else
                {
                    s = numb.Next(100);
                    /*
                     * Random random = new Random();
                     * random.Next(100);                Will return a number between 0 and 100.
                     * random.Next(100, 1000);          Will return a number between 100 and 1000;
                     */
                }
            }
        }
    }
}
