﻿/*
 * Created by: Joelle Ishimwe
 * Created on: 12-April-2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day 24 - Unicode
 * This program will converts a unicode number 
 * value into a the letter value. It then 
 * displays both values in a listbox.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicodeJoelle
{
    public partial class frmUnicode : Form
    {
        public frmUnicode()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //declare variables
            string letterValue;
            int numberValue;

            //clear items in the listbox
            this.lstUnicode.Items.Clear();

            //for loop that converts each letter into it's integer
            for (numberValue = 65; numberValue <= 90; numberValue++)
            {
                //convert counter into unicode letter
                letterValue = Char.ConvertFromUtf32 (numberValue);

                //add letter with it's value into the listbox
                this.lstUnicode.Items.Add(letterValue + "  ->  " + numberValue);
            }
        }
    }
}
