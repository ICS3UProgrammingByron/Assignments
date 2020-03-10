/*
 * Created by: Byron Edmonds-Decosse
 * Created on: 28-02-2020
 * Created for: ICS3U Programming
 * Assignment #2 - Falling Object
 * This program will tell user what the height a object has been dropped from when the user enters the time in seconds and clicks calculate
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

namespace FallingObjectsByron
{
    public partial class FallingObjectsFrm : Form
    {
        public FallingObjectsFrm()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            double time, height;

            // convert the string from each text box to a double
            time = double.Parse(txtTime.Text);

            // calculate the circumference
            height = 100 - 0.5 * 9.8 * Math.Pow(time, 2);

            // insert the circumference into the respective label
            this.lblHeight.Text = Convert.ToString(height) + " meters";

            // display the circumference label with the respective answer
            this.lblHeight.Show();
        }

        private void LblHeight_Click(object sender, EventArgs e)
        {
            
        }

        private void FallingObjectsFrm_Load(object sender, EventArgs e)
        {
            this.lblHeight.Hide();
        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            //close the program
            this.Close();
        }
    }
}
