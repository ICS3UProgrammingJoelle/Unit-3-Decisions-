﻿/*
 * Created by: Joelle Ishimwe
 * Created on: 19-March-2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #20 - Factorial Do While
 * This program displays the factorial of any number using a do while loop.
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

namespace FactorialJoelle
{
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //remove the label that intructs user's what to do
            lblClickStart.Hide();

            //declare variables
            double factorialAnswer, factorialNumber;
            int factorialCounter;

            //clear items from listbox
            this.lstFactorialNumbers.Items.Clear();

            //initialize final answer to 1
            factorialAnswer = 1;

            //get number from user
            factorialNumber = Convert.ToDouble(this.txtNumber.Text);

            //set counter to 0
            factorialCounter = 0;

            //multiply the counter by the next increment number, until it reaches the user's number
            do
            {
                //increment the counter by 1
                this.prbProgressBar.Value = factorialCounter;
                factorialCounter = factorialCounter + 1;

                //list the counter number in list box for the user to see
                lstFactorialNumbers.Items.Add(factorialCounter);

                //multiply the counter by the answer
                factorialAnswer = factorialCounter * factorialAnswer;

            } while (factorialNumber != factorialCounter);

            //convert the factorialAnswer to a string and convert it into a label
            this.lblFactorialAnwer.Text = this.txtNumber.Text + "! = " + Convert.ToString(factorialAnswer);

        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
