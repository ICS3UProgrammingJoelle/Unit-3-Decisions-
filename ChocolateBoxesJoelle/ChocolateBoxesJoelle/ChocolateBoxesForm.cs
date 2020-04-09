/*
 * Created by: Joelle Ishimwe
 * Created on: 18-March-2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #19 - Chocolate Boxes
 * This program will rewards the user according to how many chocolates they sell. 
 * If they sell over 20 boxes, they get a "prize". 
 * If a they sells less than 20 boxes but more then 10, they get "honorable mention". 
 * Otherwise, they get a "small prize" (less then 10 boxes).
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

namespace ChocolateBoxesJoelle
{
    public partial class frmChocolateBoxes : Form
    {
        public frmChocolateBoxes()
        {
            InitializeComponent();
            
            //hide the reward statement
            lblRewardStatement.Hide();
        }
        private void ChocolateBoxeForm_Load(object sender, EventArgs e)
        {
        }
        private void btnClaimReward_Click(object sender, EventArgs e)
        {
            //decalre variables
            int soldBoxes;

            //convert the numberic up down's value into an integer
            soldBoxes = Convert.ToInt32(numNumberOfSoldBoxes.Value);

            //if statement that presents your reward according to how much the user was able to sell
            if (soldBoxes > 20)
            {
                this.lblRewardStatement.Text = "CLAIM YOUR LARGE PRIZE!";
                lblRewardStatement.Show();
            }

            else if (soldBoxes < 20 && soldBoxes > 10)
            {
                this.lblRewardStatement.Text = "YOU'VE GOTTEN HONORABLE MENTIONS!";
                lblRewardStatement.Show();
            }

            else
            {
                this.lblRewardStatement.Text = "CLAIM YOUR SMALL PRIZE!";
                lblRewardStatement.Show();
            }
        }
    }
}
