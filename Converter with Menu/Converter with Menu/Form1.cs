using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter_with_Menu
{
    public partial class Converter : Form
    {
        public Converter()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblFahOutput.Text = "";
            bxInputcelcius.Text = "";
        }    

        private void btnClearPounds_Click(object sender, EventArgs e)
        {
            lblOutputEuro.Text = "";
            inputPounds.Text = "";
        }

        private void btnClearInches_Click(object sender, EventArgs e)
        {
            lblInches.Text = "";
            lblOutputFeets.Text = "";
        }

        private void btnConver_Click(object sender, EventArgs e)
        {
            lblFahOutput.Text = ((double.Parse(bxInputcelcius.Text)*9/5)+32).ToString();
            bxInputcelcius.Text = "";
        }

        private void btnConvertPounds_Click(object sender, EventArgs e)
        {
            lblOutputEuro.Text = (double.Parse(inputPounds.Text)*1.16).ToString();
            inputPounds.Text = "";
        }

        private void btnConvertInches_Click(object sender, EventArgs e)
        {
            lblOutputFeets.Text = (double.Parse(inputInches.Text)*12).ToString();
            inputInches.Text = "";
        }

        private void celciusToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelInches.Visible = false;
            panelPounds.Visible = false;
            panelCelcius.Visible = true;
        }

        private void poundsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelInches.Visible = false;
            panelPounds.Visible = true;
            panelCelcius.Visible = false;
        }

        private void inchesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelInches.Visible = true;
            panelPounds.Visible = false;
            panelCelcius.Visible = false;
        }
    }
}
