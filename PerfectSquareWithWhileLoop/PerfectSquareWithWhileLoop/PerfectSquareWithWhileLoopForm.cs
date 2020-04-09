/*
 * Created by: Joelle Ishimwe
 * Created on: 4-April-2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day # - Perfect Squre with While Loop
 * This program tells the user all the possible perfect squares,
 * until it reaches the user's chosen number. This program 
 * uses a loop to ensure all the possible perfect squares 
 * do number exceed the maximum number the user chose.
 * It also uses an IF statement to ensure that the values
 * are perfect squares.
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

namespace PerfectSquareWithWhileLoop
{
    public partial class frmPerfectSquareWithWhileLoop : Form
    {
        public frmPerfectSquareWithWhileLoop()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //declare variables
            int EndingValue, value, squareRootAsInteger;
            double squareRootAsDouble;

            //set initial values
            value = 0;

            //cleare all items in listbox
            lstPerfectSquare.ClearSelected();

            //get user's endvalue from numberic up down
            EndingValue = Convert.ToInt32(this.nudEndValue.Value);

            //state any perfect square between the initial value and the user's choosen end value
            while (value <= EndingValue)
            {
                //take the sqaure root of the value
                squareRootAsDouble = Math.Sqrt(value);

                //convert from double to integer
                squareRootAsInteger = Convert.ToInt32(squareRootAsDouble);

                if (squareRootAsInteger == squareRootAsDouble)
                {
                    //add the perfect square to the list box  
                    this.lstPerfectSquare.Items.Add(value + "   this is a perfect square");

                    //refresh the form
                    this.Refresh();
                }
                //the code to increment the value by 1
                value = value + 1;
            }
        }
    }
}
