﻿/*
 * Created by: Joelle Ishimwe
 * Created on: 8-April-2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #27 - Control Objects
 * This program  has multiple different Control 
 * Objects and changes some property for each 
 * type of control object when clicked 
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

namespace ForEachWithControlObjectsJoelle
{
    public partial class frmForEachWithControlObjects : Form
    {
        public frmForEachWithControlObjects()
        {
            InitializeComponent();
        }

        private void lblLabel_Click(object sender, EventArgs e)
        {
            //loop for each object on the form to make it blue violet
            foreach (Control Label in this.Controls)
            {
                Label.BackColor = Color.BlueViolet;
            }
        }

        private void btnButton_Click(object sender, EventArgs e)
        {
            //loop for each object on the form to make it red
            foreach (Control button in this.Controls)
            {
                button.BackColor = Color.Red;
            }
        }

        private void nudNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            //loop for each object on the form to make it Pink
            foreach (Control numericUpDown in this.Controls)
            {
                numericUpDown.BackColor = Color.Pink;
            }
        }
        private void lstListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void chbCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //loop for each object on the form to make it Lavender
            foreach (Control CheckBox in this.Controls)
            {
                CheckBox.BackColor = Color.Lavender;
            }
        }
        private void frmForEachWithControlObjects_Load(object sender, EventArgs e)
        {
        }
    }
}
