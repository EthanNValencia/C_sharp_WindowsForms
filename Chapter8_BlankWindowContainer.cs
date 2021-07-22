using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
/*
 * Example 8-1, page 405. 
 * This is simply meant to demonstrate how an empty 
 * window can be made. 
 */
namespace Chapter6_WinFormsApp
{
    class Chapter8_BlankWindowContainer : Form
    {
        public Chapter8_BlankWindowContainer()
        {
            Text = "Simple Windows Application";
        }
        public void Run()
        {
            Chapter8_BlankWindowContainer winForm = new Chapter8_BlankWindowContainer();
            Application.Run(winForm);
        }
    }
}
