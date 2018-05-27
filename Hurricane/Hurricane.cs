/********************************************************************
 * Assignment from SDEV 240                                         *
 * Coded by: Harley Ehrman                                          *
 *                                                                  *
 * From book:                                                       *
 * Microsoft Visual C# 2015:                                        *
 * An Introduction to Object-Oriented Programming 6th Edition       *
 * by Joyce Farrell                                                 *
 *                                                                  *
 * Instructions (Page 186, Exercise 4):                             *
 * The Saffir-Simpson Hurricane Scale classifies hurricanes into    *
 * five categories numbered 1 through 5. Write an application       *
 * named Hurricane that outputs a hurricane’s category based on the * 
 * user’s input of the wind speed. Category 5 hurricanes have       *
 * sustained winds of at least 157 miles per hour. The minimum      *
 * sustained wind speeds for categories 4 through 1 are 130, 111,   *
 * 96, and 74 miles per hour, respectively. Any storm with winds of *
 * less than 74 miles per hour is not a hurricane.                  *
 ********************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hurricane
{
    public partial class Hurricane : Form
    {
        public Hurricane()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //declare constants and variables
            const int CAT5 = 157, CAT4 = 130, CAT3 = 111, CAT2 = 96, CAT1 = 74;
            double WindSpeed = Convert.ToDouble(txtInput.Text);
            string Category;

            //determine hurricane category
            if (WindSpeed >= CAT5)
                Category = "a category 5 hurricane.";
            else if (WindSpeed >= CAT4)
                Category = "a category 4 hurricane.";
            else if (WindSpeed >= CAT3)
                Category = "a category 3 hurricane.";
            else if (WindSpeed >= CAT2)
                Category = "a category 2 hurricane.";
            else if (WindSpeed >= CAT1)
                Category = "a category 1 hurricane.";
            else
                Category = "not a hurricane.";

            //output
            lblOutput.Text = "A windspeed of " + WindSpeed + "mph is " + Category;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
