/*
 * Created by: Joelle Ishimwe
 * Created on: 4-April-2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day # - Sum of Numbers
 * This program will get a positive number, form the user.
 * Then  it calculates the sum of all numbers, until it 
 * reaches that given number, from the user.
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

namespace SumOfNumbersJoelleI
{
    public partial class frmSumOfNumbers : Form
    {
        public frmSumOfNumbers()
        {
            InitializeComponent();
            this.lblAnswer.Hide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //declare variables and constants
            double answer, number, calculations;
            int counter;

            //clear the listbox
            this.lstAddingNumber.Items.Clear();

            //initialize the final answer to one
            //answer = 1;

            //get the number from user and asign it to the appropriate variable
            number = Convert.ToDouble(this.txtMaxNumber.Text);

            //the for loop
            for(counter = 1; counter <= number; counter++)
            {
                //calculate the sum using the Gauss formula
                calculations = (number * (number + 1)) / 2;

                //dipslay the counter in list box
                this.lstAddingNumber.Items.Add (counter);

                //add up all the numbers before the the user's entered number
                answer = calculations;

                //display the answer as a label
                this.lblAnswer.Text = Convert.ToString(answer);
            
                //hide the label that display's the answer
                this.lblAnswer.Show();
            }
        }
    }
}
