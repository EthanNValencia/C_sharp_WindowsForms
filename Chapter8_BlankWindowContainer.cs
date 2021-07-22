using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
/*
 * Example 8-1, page 405. 
 * This is simply meant to demonstrate how an empty 
 * window can be made. 
 * 
 * C# is a single inheritance language. Just like Java.
 */
namespace Chapter6_WinFormsApp
{
    class Chapter8_BlankWindowContainer : Form // Form is the "base class", Chapter8_BlankWindowContainer is a derived class from the base class.  
    {  // Chapter8_BlankWindowContainer IS A Form. 
        public Chapter8_BlankWindowContainer() // Constructor
        {
            Text = "Simple Windows Application"; // Text is an inheritted property from the Form base class. 
        }
        public void Run() // This is meant to be a main method, but for note taking purposes, I am doing it like this. 
        {
            Chapter8_BlankWindowContainer winForm = new Chapter8_BlankWindowContainer(); // The object is created 
            Application.Run(winForm); // The Chapter8 object is passed into the Application.Run()
            /* 
             * The Application class is part of the System.Windows.Forms namespace. 
             * Passing the Chapter8_BlankWindowContainer to the Application.Run() is
             * the beginning of what results in a window being displayed. 
             */
        }
    }
}
/*
 * The textbook claims it is possible to write the code in notepad and then launch
 * the code from the command line. Kind of an interesting idea. 
 */
