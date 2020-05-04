/*
 * Created by: Joelle Ishimwe
 * Created on: 12-April-2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #29 - Running Average
 * This program that keeps accepting input (between 0 and 100), 
 * then shows the "running average", 
 * until a user enter's -1
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

namespace RunningAverageJor
{           
    public partial class frmRunningAverage : Form
    {    
        //decalre variables
        double sum = 0;
        int numMarks = 0;
        
        public frmRunningAverage()
        {
            InitializeComponent();
            
            //hide the answer label
            this.lblAverage.Hide();
        }

        private void btnCalculateAverage_Click(object sender, EventArgs e)
        {
            //declare variables
            double mark;
            double average;

            //set the variable to zero
            mark = double.Parse(txtNumber1.Text);

            //allows user to enter any number between 1-100
            if (mark == -1)
            {
                MessageBox.Show("Running average ended", "Running Average");
                this.btnCalculateAverage.Enabled = false;
                this.txtNumber1.Enabled = false;
            }
            
            //if user's enters -1 display goodbye message and disable buttons
            else
            {
                //update the number of marks
                numMarks++;

                //update the sum
                sum = sum + mark;

                //calculate average
                average = sum / numMarks;

                //display answer
                this.lblAverage.Show();
                lblAverage.Text = Convert.ToString(average);
            }
        }

        private void lblNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
