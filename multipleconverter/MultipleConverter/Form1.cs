using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleConverter
{
    public partial class Form1 : Form
    {
        double inputValue, result;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void inchesSelected_CheckedChanged(object sender, EventArgs e)
        {
            lblInputs.Text = "Please Enter Inches";
            lblResults.Text = "Feets:";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblConverted.Text = "";
            inputField.Text = "";
        }

        private void poundSelected_CheckedChanged(object sender, EventArgs e)
        {
            lblInputs.Text = "Please Enter Pounds";
            lblResults.Text = "Euros:";

        }

        private void celciusSelected_CheckedChanged(object sender, EventArgs e)
        {
            lblInputs.Text = "Please Enter Celcius";
            lblResults.Text = "Fahrenheit";
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
           // double convert; 

            if (inchesSelected.Checked == true)
            {
                
                lblConverted.Text =(double.Parse(inputField.Text) / 12).ToString();
            }
            else if(poundSelected.Checked == true)
            {
                lblConverted.Text = (double.Parse(inputField.Text) * 1.16).ToString();
            
            }
            else
            {
                lblConverted.Text = ((double.Parse(inputField.Text) * 9/5)+32).ToString();
                
            }
        }
    }
}
