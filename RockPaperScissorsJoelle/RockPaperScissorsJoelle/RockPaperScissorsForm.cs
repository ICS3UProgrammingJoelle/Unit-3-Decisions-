/*
 * Created by: Joelle Ishiwme
 * Created on: 19-March-202
 * Created for: ICS3U Programming
 * Daily Assignment – Day #18 - Rock, Paper, Scissors
 * This program  will generate a random number between 1-3 (rock, paper or scissors). 
 * The user will being play against the random generator. The game 
 * could either end in a win, lose or a tie.
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

namespace RockPaperScissorsJoelle
{
    public partial class frmRockPaperScissors : Form
    {
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 3;
        Random randomNumberGenerator;

        public frmRockPaperScissors()
        {
            InitializeComponent();

            //hide the label that tell's the user the verdit
            lblWinLoseTieStatement.Hide();

            //create a random number generator object
            randomNumberGenerator = new Random();
        }

        private void lblChoose_Click(object sender, EventArgs e)
        {

        }

        private void frmRockPaperScissors_Load(object sender, EventArgs e)
        {

        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {

            //declare variables
            int usersChoice, computersChoice;

            //declare constants
            const int ROCK = 1;
            const int PAPER = 2;
            const int SCISSORS = 3;

            //get the user's selection if there's no selection set it to zero.
            if (radPlayerRock.Checked == true)
            {
                usersChoice = ROCK;
            }

            else if (radPlayerPaper.Checked == true)
            {
                usersChoice = PAPER;
            }
            
            else if (radPlayerScissors.Checked == true)
            {
                usersChoice = SCISSORS;
            }
            
            else
            {
                usersChoice = 0;
            }


            //genrate the random rock, paper, scissors
            computersChoice = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);

            //set the computer's choice
            if (computersChoice == ROCK)
            {
                this.radComputerRock.Checked = true;
            }

            else if (computersChoice == PAPER)
            {
                this.radComputerPaper.Checked = true;
            }

            else
            {
                this.radComputerScissors.Checked = true;
            }


            //compare the user's choice with the random generator's
            if (usersChoice == computersChoice)
            {
                this.lblWinLoseTieStatement.Text = "You tied";
                lblWinLoseTieStatement.Show();
            }

            else if (usersChoice == ROCK && computersChoice == PAPER)
            {
                this.lblWinLoseTieStatement.Text = "You lost";
                lblWinLoseTieStatement.Show();

            }

            else if (usersChoice == ROCK && computersChoice == SCISSORS)
            {
                this.lblWinLoseTieStatement.Text = "YOU WON!";
                lblWinLoseTieStatement.Show();

            }

            else if (usersChoice == PAPER && computersChoice == ROCK)
            {
                this.lblWinLoseTieStatement.Text = "YOU WON!";
                lblWinLoseTieStatement.Show();

            }
            
            else if (usersChoice == PAPER && computersChoice == SCISSORS)
            {
                this.lblWinLoseTieStatement.Text = "You lost";
                lblWinLoseTieStatement.Show();

            }
            
            else if (usersChoice == SCISSORS && computersChoice == PAPER)
            {
                this.lblWinLoseTieStatement.Text = "YOU WON!";
                lblWinLoseTieStatement.Show();

            }
            
            else if (usersChoice == SCISSORS && computersChoice == ROCK)
            {
                this.lblWinLoseTieStatement.Text = "You lost";
                lblWinLoseTieStatement.Show();

            }
        }
    }
}
