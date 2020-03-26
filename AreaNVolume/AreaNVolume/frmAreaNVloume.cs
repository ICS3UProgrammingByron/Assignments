/*
 * Created by: Byron Edmonds-Decosse
 * Created on: 26-3-2020
 * Created for: ICS3U Programming
 * Assignment #4b - AreaNVolume
 * This program calculates the area and volume of various shapes when the user gives the measurements and clicks on the calculate button
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

namespace AreaNVolume
{
    public partial class frmAreaNVloume : Form
    {
        public frmAreaNVloume()
        {
            InitializeComponent();
        }

        private void frmAreaNVloume_Load(object sender, EventArgs e)
        {
            //hide the labels 
            this.lblVolumeAnswer2.Hide();

            this.lblVolumeAnswer1.Hide();

            this.lblAreaAnswer.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate1_Click(object sender, EventArgs e)
        {
            //declare local variables
            double topbase, bottombase, height, area;

            //convert to string from each text box to a double
            topbase = double.Parse(txtTopBase.Text);

            bottombase = double.Parse(txtBottomBase.Text);

            height = double.Parse(txtHeight.Text);

            //calculate the area

            area = 1 / 2 * (topbase * bottombase) * height;

            //insert the area into their respective label
            this.lblAreaAnswer.Text = Convert.ToString(area) + " squared centimeters";

            //display the area label with their respective answers
            this.lblAreaAnswer.Show();
        }

        private void btnCalculate2_Click(object sender, EventArgs e)
        {
            //declare local variables 
            double height, radius, volume;

            //convert the string from each text box to a double
            radius = double.Parse(txtRadius.Text);

            height = double.Parse(txtHeight2.Text);

            //calculate the volume of the cylinder
            volume = Math.PI * Math.Pow(radius, 2) * height;

            //insert the volume into their respective label
            this.lblVolumeAnswer1.Text = Convert.ToString(volume) + " cubed centimeters";

            //display the volume label with the respective answer
            this.lblVolumeAnswer1.Show();
        }

        private void btnCalculate3_Click(object sender, EventArgs e)
        {
            //declare local variables 
            double radius, volume;

            //convert the string from each text box to a double 
            radius = double.Parse(txtRadius2.Text);

            //calculate the the volume of a sphere
            volume = 4 / 3 * Math.PI * Math.Pow(radius, 3);

            //insert the volume into their respective label
            this.lblVolumeAnswer2.Text = Convert.ToString(volume) + " cubed centimeters";

            //display the volume with the respective ansewr
            this.lblVolumeAnswer2.Show();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //close the program
            this.Close();
        }
    }
}
