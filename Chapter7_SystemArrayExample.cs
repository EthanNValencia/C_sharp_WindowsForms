using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace Chapter6_WinFormsApp
{
    class Chapter7_SystemArrayExample // Example 7-12, pg 348-349
    {
        public const string CAPTION = "System.Array Methods Illustrated"; // Constant

        public static void Run()
        {
            double[] waterDepth = { 24, 19, 2, 16.8, 190, 0.8, 510, 6, 18 };
            double[] w = new double[20]; // w array is empty
            DisplayOutput(waterDepth, "waterDepth Array\n\n");

            // Copies values from waterDepth to w
            Array.Copy(waterDepth, 2, w, 0, 5);

            // Sorts Array w in ascending order
            Array.Sort(w);
            DisplayOutput(w, "Array w Sorted\n\n");

            // Reverse the elements in Array w
            Array.Reverse(w);
            DisplayOutput(w, "Array w Reversed\n\n");
        }

        public static void DisplayOutput(double[] anArray, string msg)
        {
            foreach (double wVal in anArray) // The overall length of w is 20, but this allow for traversal only if a value is stored. (won't throw an outofboundsexception)
                if (wVal > 0)
                    msg += wVal + "\n";
            MessageBox.Show(msg, CAPTION);
        }
    }
}
