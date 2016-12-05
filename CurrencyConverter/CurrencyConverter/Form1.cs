using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblConAmount.Text = "0.0";
            txtMoneyAmountInput.Text = "";

        }
        private void comFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }
        private void btnConcert_Click(object sender, EventArgs e)
        {            
            if (fromCurrency.Text == "Euro" && toCurrency.Text == "Pound")
            {           
                lblConAmount.Text = (Double.Parse(txtMoneyAmountInput.Text) * 0.86).ToString();
                txtMoneyAmountInput.Text = lblConAmount.Text;       
            }
            else if (fromCurrency.Text == "Euro" && toCurrency.Text == "US Dollar")
            {
                lblConAmount.Text = (Double.Parse(txtMoneyAmountInput.Text) * 1.12).ToString();
                txtMoneyAmountInput.Text = lblConAmount.Text;
            }
           
            else if (fromCurrency.Text == "Pound" && toCurrency.Text == "Euro")
            {
                lblConAmount.Text = (Double.Parse(txtMoneyAmountInput.Text) * 1.16).ToString();
                txtMoneyAmountInput.Text = lblConAmount.Text;
            }
            else if (fromCurrency.Text == "Pound" && toCurrency.Text == "US Dollar")
            {
                lblConAmount.Text = (Double.Parse(txtMoneyAmountInput.Text) * 1.3).ToString();
                txtMoneyAmountInput.Text = lblConAmount.Text;
            }
         
            else if (fromCurrency.Text == "US Dollar" && toCurrency.Text == "Euro")
            {
                lblConAmount.Text = (Double.Parse(txtMoneyAmountInput.Text) * 0.9).ToString();
                txtMoneyAmountInput.Text = lblConAmount.Text;
            }
            else if (fromCurrency.Text == "US Dollar" && toCurrency.Text == "Pound")
            {
                lblConAmount.Text = (Double.Parse(txtMoneyAmountInput.Text) * 0.77).ToString();
                txtMoneyAmountInput.Text = lblConAmount.Text;
            }
            else 
            {
                lblConAmount.Text = txtMoneyAmountInput.Text;
                txtMoneyAmountInput.Text = lblConAmount.Text;
            }
        }
    }
}
